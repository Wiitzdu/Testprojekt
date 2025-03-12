using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using System.Collections;

public class changeScene : MonoBehaviour
{
    private bool sceneLoaded=false;
    private bool sceneChanged=false;

    public CanvasGroup fadeCanvasGroup;
    public float fadeDuration = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.spaceKey.wasPressedThisFrame)
        //{
        //    changeScenes();
        //}
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void changeScenes()
    {
        SceneManager.LoadScene("Part 1 - wormhole only", LoadSceneMode.Single);


    }
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

    }
}
