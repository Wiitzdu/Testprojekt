using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Animations;
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

        //transform.rotation = quaternion.EulerXYZ(parentRotation * (-1));
        //transform.LookAt(player, Vector3.up);
        GetComponent<RectTransform>().LookAt(player, Vector3.up);
        //GetComponent<RectTransform>().Rotate(0,1,0);
        //transform.Rotate(0f, 180f, 0f, Space.Self);

    }
}
