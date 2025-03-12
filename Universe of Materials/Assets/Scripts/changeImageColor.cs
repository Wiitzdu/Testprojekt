using UnityEngine;

public class changeImageColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColorBlue()
    {
        GetComponent <UnityEngine.UI.Image>().color = Color.blue;
    }
    public void changeColorRed()
    {
        GetComponent <UnityEngine.UI.Image>().color = Color.red;
    }
}
