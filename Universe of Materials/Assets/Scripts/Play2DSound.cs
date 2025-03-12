using FMODUnity;
using UnityEngine;

public class Play2DSound : MonoBehaviour
{
    [SerializeField] EventReference Event2D;

    public void Play2DSoundEvent()
    {
        RuntimeManager.PlayOneShot(Event2D);
    }

    public void OnDestroy()
    {
        Play2DSoundEvent();
    }
}
