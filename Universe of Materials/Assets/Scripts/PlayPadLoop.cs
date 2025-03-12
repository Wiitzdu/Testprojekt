using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayPadLoop : MonoBehaviour
{
    [SerializeField] EventReference PadEvent;
    private EventInstance padInstance;

    void Start()
    {
        padInstance = RuntimeManager.CreateInstance(PadEvent);
        padInstance.start();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) // Change 'spaceKey' to any key
        {
            padInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            padInstance.release(); // Clean up the instance
        }
    }
}
