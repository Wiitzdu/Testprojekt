using UnityEditor.UI;
using UnityEngine;

public class WarpEffect : MonoBehaviour
{
    public bool zoomEnabled = false;
    public float zoomSpeed = 10f;
    public float zoomMinDistance = 0.1f;
    public float zoomMaxDistance = 80f;

    public bool warpEnabled = false;
    public float warpMinFOV = 5f;
    public float warpMaxFOV = 90f;

    public bool scaleEnabled = true;
    public float scaleSpeed = 0.5f;
    public float scaleStrength = 0.2f;

    public Camera mainCamera;
    public Material warpMaterial;

    private Vector3 cameraStartPos;

    void Start()
    {
        cameraStartPos = transform.position;
    }

    void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput != 0)
        {
            if (warpEnabled)
            {
                float newFOV = mainCamera.fieldOfView - scrollInput * zoomSpeed;
                mainCamera.fieldOfView = Mathf.Clamp(newFOV, warpMinFOV, warpMaxFOV);
            }

            // Move the camera forward (dive effect)
            if (zoomEnabled)
            {
                Vector3 cameraNewPos = transform.position + scrollInput * zoomSpeed * transform.forward;
                float distance = Vector3.Distance(cameraStartPos, cameraNewPos);
                if (distance >= zoomMinDistance && distance <= zoomMaxDistance)
                {
                    transform.position = cameraNewPos;
                }
            }

            if (scaleEnabled)
            {
                float warpFactor = scrollInput * scaleStrength;
                warpMaterial.mainTextureScale = new Vector2(1 + warpFactor, 1 + warpFactor);
            }
        }
    }
}