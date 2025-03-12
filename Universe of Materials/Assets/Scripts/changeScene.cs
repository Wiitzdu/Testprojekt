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
        if(sceneLoaded&&sceneChanged)
        {
            Scene scene= SceneManager.GetSceneByName("Microscopic Concrete");
            SceneManager.SetActiveScene(scene); 
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void changeScenes()
    {
        SceneManager.LoadScene("Microscopic Concrete", LoadSceneMode.Additive);
        sceneChanged = true;

    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        sceneLoaded = true;
    }
}
