using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingPanel : MonoBehaviour
{
    Image panel;
    SpriteRenderer sprite;
    Text text;
    Color panelColor, spriteColor, textColor;
    float alpha;
    bool fadeOut;
    public float speed = 0.01f;
    public float delay = 2.0f;

    void Awake()
    {
        alpha = 1.0f;
        fadeOut = false;
        panel = GetComponent<Image>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        text = GetComponentInChildren<Text>();
        UpdateColor();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("FadeOut", delay);
        if (fadeOut) 
        {
            alpha -= speed;
            UpdateColor();
            if (alpha < 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void UpdateColor()
    {
        panelColor = new Color(
            panel.color.r,
            panel.color.g,
            panel.color.b,
            alpha
        );
        spriteColor = new Color(
            sprite.color.r,
            sprite.color.g,
            sprite.color.b,
            alpha
        );
        textColor = new Color(
            text.color.r,
            text.color.g,
            text.color.b,
            alpha
        );
        panel.color = panelColor;
        sprite.color = spriteColor;
        text.color = textColor;
    }

    private void FadeOut()
    {
        fadeOut = true;
    }
}
