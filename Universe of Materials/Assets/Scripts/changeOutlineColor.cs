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

    public void changeOutlineColorSelected()
    {
        Renderer renderer = transform.parent.gameObject.GetComponent<MeshRenderer>();
        GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
    }
    public void changeOutlineColorUnselected()
    {
        Renderer renderer = transform.parent.gameObject.GetComponent<MeshRenderer>();
        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }


}

