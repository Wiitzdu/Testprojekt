using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneLoaderNew : MonoBehaviour
{
    public static SceneLoaderNew instance;

    public UnityEngine.UI.RawImage transitionImage;

    public void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            LoadScene();
        }
    }

    private void Awake()
    {
        instance = this;
        SceneManager.LoadScene("main", LoadSceneMode.Additive);
    }

    public void LoadScene()
    {
        string to = "Part 1 - wormhole only";

        transitionImage.texture = _GetCameraScreenshot();

        AsyncOperation op = SceneManager.LoadSceneAsync(to, LoadSceneMode.Additive);
        op.completed += (_) =>
        {
            SceneManager.UnloadSceneAsync("main");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(to));

            StartCoroutine(_FadingOut());
        };
    }

    private Texture2D _GetCameraScreenshot()
    {
        Camera cam = Camera.main;
        int w = cam.pixelWidth;
        int h = cam.pixelHeight;

        RenderTexture rt = new RenderTexture(w, h, 24, RenderTextureFormat.ARGB32);
        rt.antiAliasing = 2;

        cam.targetTexture = rt;
        cam.Render();

        RenderTexture.active = rt;
        Texture2D output = new Texture2D(w, h, TextureFormat.RGB24, false);
        output.ReadPixels(new Rect(0, 0, w, h), 0, 0, false);
        output.Apply();

        RenderTexture.active = null;
        cam.targetTexture = null;
        rt.DiscardContents();
        rt.Release();

        return output;
    }

    private IEnumerator _FadingOut()
    {
        Color from = Color.white;
        Color to = new Color(1, 1, 1, 0);
        float t = 0f;
        while (t < 0.8f)
        {
            transitionImage.color = Color.Lerp(from, to, t / 0.5f);
            t += Time.deltaTime;
            yield return null;
        }
    }
}
