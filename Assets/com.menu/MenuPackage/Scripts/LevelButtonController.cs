using System;
//using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButtonController : MonoBehaviour
{
    [SerializeField]
    private /*TMP_Text*/ Text levelNumber;
    [SerializeField]
    private Image image;

    public void Set(int buildIndex, Color textColor, /*TMP_FontAsset*/ Font font = null, Sprite sprite = null)
    {
        levelNumber.text = $"{buildIndex}";
        levelNumber.color = textColor;
        if (font != null)
        {
            levelNumber.font = font;
        }

        if (sprite != null)
        {
            image.sprite = sprite;
            image.type = Image.Type.Simple;
            image.preserveAspect = true;
        }
    }

    public void OnClick()
    {
        SceneManager.LoadSceneAsync(Convert.ToInt32(levelNumber.text));
    }
}