using FMODUnity;
using UnityEngine;

public class RunStones : MonoBehaviour
{
    [SerializeField] EventReference StoneEvent;
    [SerializeField] GameObject attachTo;

    public void PlayStoneSound()
    {
        RuntimeManager.PlayOneShotAttached(StoneEvent, attachTo);
    }
}
