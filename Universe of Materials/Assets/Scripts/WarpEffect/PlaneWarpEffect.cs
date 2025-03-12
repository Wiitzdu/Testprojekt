using System.Resources;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlaneWarpEffect : MonoBehaviour
{
    public bool warpEnabled = false;
    public float warpStrength = 0.2f;

    public bool scaleEnabled = true;
    public float scaleSpeed = 5f;
    public float scaleMaxDistance = 0.05f;

    private Material material;
    private Vector2 matScale = Vector2.one;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        if (Mouse.current == null) return;

        float scrollInput = Mouse.current.scroll.ReadValue().y * 0.1f;

        if (scrollInput == 0) return;

        if (warpEnabled)
        {
            // ✅ Create a warp effect by slightly skewing the plane
            float warpFactor = Mathf.Sin(Time.time * scrollInput) * warpStrength;
            transform.localScale += new Vector3(warpFactor, 0, warpFactor);
        }

        if (scaleEnabled && material != null)
        {
            matScale += new Vector2(scrollInput * scaleSpeed, scrollInput * scaleSpeed);
            matScale = new Vector2(Mathf.Max(scaleMaxDistance, matScale.x), Mathf.Max(scaleMaxDistance, matScale.y)); // Prevent negative scaling

            // ✅ Adjust texture offset to keep it centered
            Vector2 newOffset = new Vector2(0.5f, 0.5f) * (Vector2.one - matScale);

            // Apply changes
            material.mainTextureScale = matScale;
            material.mainTextureOffset = newOffset;
        }
    }
}
