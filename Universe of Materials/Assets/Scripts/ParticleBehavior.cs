using UnityEngine;
using UnityEngine.UI;

public class ParticleBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject distanceObject;
    [SerializeField]
    private float distance=0.5f;
    [SerializeField]
    private GameObject canvasObject;

    //public Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Distance" + this.name+ Vector3.Distance(distanceObject.transform.position, transform.position));
        //text.text = (string)("Distance" + this.name + Vector3.Distance(distanceObject.transform.position, transform.position));

        
        if (Vector3.Distance(distanceObject.transform.position, transform.position)<=distance&& !canvasObject.activeSelf)
        {
            //text.text = "setting text object active";
            //GameObject canvas = transform.Find("Canvas").gameObject;
            
            canvasObject.SetActive(true);
        }
        else if(Vector3.Distance(distanceObject.transform.position, transform.position) > distance && canvasObject.activeSelf)
        {
     
            canvasObject.SetActive(false);
            //text.text = "setting text object inactive";
        }


    }
}
