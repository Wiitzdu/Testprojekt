using Unity.Mathematics;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;

public class infoText : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    float fadeDuration=3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnEnable()
    {
        StartCoroutine(FadeIn());
    }
    private void OnDisable()
    {
        StartCoroutine (FadeOut());
    }

    // Update is called once per frame
    void Update()
    {

        //transform.rotation = quaternion.EulerXYZ(parentRotation * (-1));
        //transform.LookAt(player, Vector3.up);
        //GetComponent<RectTransform>().LookAt(player, Vector3.up);
        //GetComponent<RectTransform>().Rotate(0,1,0);
        //transform.Rotate(0f, 180f, 0f, Space.Self);

    }

    private IEnumerator FadeOut()
    {
        Image im = GetComponent<Image>();
        Color initialColor = im.color;
        Color targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, 0f);

        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            im.color = Color.Lerp(initialColor, targetColor, elapsedTime / fadeDuration);
            yield return null;
        }
    }

    private IEnumerator FadeIn()
    {
        Image im = GetComponent<Image>();
        Color initialColor = im.color;
        Color targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, 1f);

        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            im.color = Color.Lerp(initialColor, targetColor, elapsedTime / fadeDuration);
            yield return null;
        }
    }
}
