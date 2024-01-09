using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DelayTypes : MonoBehaviour
{
    [SerializeField]
    private float delayTime = 1f;

    [SerializeField]
    private TMP_Text text;

    private float timer = 0f;

    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Color color;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "0.00";
        timer = Time.time;
        spriteRenderer = GetComponent<SpriteRenderer>();

        //Invoke(nameof(ChangeColor), delayTime);

        //InvokeRepeating(nameof(ChangeColorRepeat), delayTime, delayTime);

        StartCoroutine(ChangeColorCoroutine(color));
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (Time.time - timer).ToString("0.00");
    }

    void ChangeColor()
    {
        spriteRenderer.color = color;
    }
    void ChangeColorRepeat()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    IEnumerator ChangeColorCoroutine(Color color)
    {
        yield return new WaitForSeconds(2);
        spriteRenderer.color = color;
    }
}
