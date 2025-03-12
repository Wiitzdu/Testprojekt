using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    private bool sceneLoaded=false;
    private bool sceneChanged=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
