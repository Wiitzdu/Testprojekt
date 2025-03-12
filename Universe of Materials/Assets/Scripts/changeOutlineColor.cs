using UnityEngine;

public class changeOutlineColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider)
    {
        Material material = collider.gameObject.GetComponent<MeshRenderer>().GetComponent<Material>();
        material.SetColor("_Color", Color.red);
    }

}
