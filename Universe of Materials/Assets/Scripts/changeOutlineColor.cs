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

    public void changeOutlineColorBlue()
    {
        Renderer renderer = transform.parent.gameObject.GetComponent<MeshRenderer>();
        GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
    }
    public void changeOutlineColorRed()
    {
        Renderer renderer = transform.parent.gameObject.GetComponent<MeshRenderer>();
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }

    public void changeOutlineColorTransparent()
    {
        Renderer renderer = transform.parent.gameObject.GetComponent<MeshRenderer>();
        GetComponent<Renderer>().material.SetColor("_Color", Color.clear);
    }


}

