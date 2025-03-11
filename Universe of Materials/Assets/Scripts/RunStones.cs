using FMODUnity;
using UnityEngine;

public class RunStones : MonoBehaviour
{
    [SerializeField] EventReference StoneEvent;
    [SerializeField] float rate;

    float time;

    public void PlayStoneSound()
    {
        RuntimeManager.PlayOneShot(StoneEvent);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > rate)
        {
            PlayStoneSound();
            time -= rate;
        }

    }
}
