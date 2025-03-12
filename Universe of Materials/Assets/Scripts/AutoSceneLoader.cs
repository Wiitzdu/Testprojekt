using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSceneLoader : MonoBehaviour
{
    public string sceneToLoad = "Microscopic Concrete";
    public float loadAfterSecs = 10f;

    void Start()
    {
        if (string.IsNullOrEmpty(sceneToLoad))
        {
            Debug.LogError("You must provide a scene name!");
            return;
        }
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(loadAfterSecs);
        SceneManager.LoadScene(sceneToLoad.ToString(), LoadSceneMode.Single);
    }
}
