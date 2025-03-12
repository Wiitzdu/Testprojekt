using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class infoText : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player, Vector3.up);
        transform.Rotate(0f, 180f, 0f, Space.Self);
    }
}
