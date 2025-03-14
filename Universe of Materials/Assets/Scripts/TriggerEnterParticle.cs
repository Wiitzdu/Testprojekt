using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterParticle : MonoBehaviour
{
    public UnityEvent enteredTrigger;
    public UnityEvent exitTrigger;
    public UnityEvent stayTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject canvas= other.transform.parent.Find("Canvas").gameObject;
        canvas.SetActive(true);
        enteredTrigger?.Invoke();
        

    }
    private void OnTriggerExit(Collider other)
    {
        GameObject canvas = other.transform.parent.Find("Canvas").gameObject;
        canvas.SetActive(false);
        exitTrigger?.Invoke();
        
       
    }

    private void OnTriggerStay(Collider other)
    {

            stayTrigger?.Invoke();
        

    }
}