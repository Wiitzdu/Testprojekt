using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToCopy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=objectToCopy.transform.position;
    }
}
