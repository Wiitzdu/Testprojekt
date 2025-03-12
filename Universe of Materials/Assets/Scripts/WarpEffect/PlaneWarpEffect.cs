using UnityEngine;


public class PlaneWarpEffect : MonoBehaviour
{
    public bool scaleEnabled = true;
    public float scale = 1f;
    public float scaleMinDistance = 0.05f;

    public bool warpEnabled = true;
    public float warpStrength = 0.01f; // How much the warp effect distorts the plane

    private MeshFilter meshFilter;
    private Vector3[] originalVertices;
    private Vector3[] modifiedVertices;

    private Material material;
    private Vector2 textureScale = Vector2.one;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        SetupMeshWarp();
    }

    void Update()
    {
        ScaleTexture();
        WarpMesh();
    }

    void SetupMeshWarp()
    {
        meshFilter = GetComponent<MeshFilter>();

        if (meshFilter == null || meshFilter.mesh == null)
        {
            Debug.LogError("No Mesh found on object!");
            return;
        }

        Debug.Log("Vertex Count: " + meshFilter.mesh.vertexCount);

        originalVertices = meshFilter.mesh.vertices;
        modifiedVertices = new Vector3[originalVertices.Length];
    }

    void ScaleTexture()
    {
        if (!scaleEnabled || material == null) return;

        textureScale = new Vector2(scale, scale);
        textureScale = new Vector2(
            Mathf.Max(scaleMinDistance, textureScale.x),
            Mathf.Max(scaleMinDistance, textureScale.y)
        ); // Prevent negative scaling

        Vector2 newOffset = new Vector2(0.5f, 0.5f) * (Vector2.one - textureScale);

        material.mainTextureScale = textureScale;
        material.mainTextureOffset = newOffset;
    }

    void WarpMesh()
    {
        if (!warpEnabled)
        {
            meshFilter.mesh.vertices = originalVertices;
            return;
        }

        if (warpStrength < 0)
        {
            warpStrength = 0;
            return;
        }

        for (int i = 0; i < originalVertices.Length; i++)
        {
            Vector3 vertex = originalVertices[i];

            // Calculate distance from center
            float distanceSquared = Mathf.Sqrt(vertex.x * vertex.x + vertex.z * vertex.z);
            float pincushionFactor = 1 + (warpStrength * distanceSquared * distanceSquared);

            // Apply pincushion effect by scaling outward from the center
            vertex.x *= pincushionFactor;
            vertex.z *= pincushionFactor;

            modifiedVertices[i] = vertex;
        }

        // Apply vertex changes
        meshFilter.mesh.vertices = modifiedVertices;
        meshFilter.mesh.RecalculateNormals();
        meshFilter.mesh.RecalculateBounds();
    }
}
