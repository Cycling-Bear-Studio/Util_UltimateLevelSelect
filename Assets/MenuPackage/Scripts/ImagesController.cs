using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImagesController : MonoBehaviour
{
    [Header("Buttons Images"), SerializeField]
    private Image playButonImage;
    [SerializeField]
    private Image levelsMenuButtonImage;
    [SerializeField]
    private Image backButtonImage;

    [Header("Buttons Texts"), SerializeField]
    private TMP_Text playButonText;
    [SerializeField]
    private TMP_Text levelsMenuButtonText;
    [SerializeField]
    private TMP_Text backButtonText;

    [Header("Variables"), SerializeField]
    private bool showButtonsTexts;

    [Header("Sprites"), SerializeField]
    private Sprite playButonSprite;
    [SerializeField]
    private Sprite levelsMenuButtonSprite;
    [SerializeField]
    private Sprite backButtonSprite;
    [SerializeField]
    private Sprite levelButtonSprite;

    [Header("Fonts"), SerializeField]
    private TMP_FontAsset buttonsFont;

    [Header("Colors"), SerializeField]
    private Color textColor;

    private void Start()
    {
        SetSprites();
        if(showButtonsTexts)
        {
            SetFontToButtonsTexts();
        }
        else
        {
            DisableButtonsTexts();
        }
    }

    public Sprite GetLevelButtonSprite()
    {
        return levelButtonSprite;
    }

    public TMP_FontAsset GetFont()
    {
        return buttonsFont;
    }

    public Color GetTextColor()
    {
        return textColor;
    }

    private void SetSprites()
    {
        if (playButonSprite != null)
        {
            playButonImage.sprite = playButonSprite;
            playButonImage.type = Image.Type.Simple;
            playButonImage.preserveAspect = true;
        }
        if (levelsMenuButtonSprite != null)
        {
            levelsMenuButtonImage.sprite = levelsMenuButtonSprite;
            levelsMenuButtonImage.type = Image.Type.Simple;
            levelsMenuButtonImage.preserveAspect = true;
        }
        if (backButtonSprite != null)
        {
            backButtonImage.sprite = backButtonSprite;
            backButtonImage.type = Image.Type.Simple;
            backButtonImage.preserveAspect = true;
        }
    }

    private void SetFontToButtonsTexts()
    {
        if(buttonsFont !=null)
        {
            if (playButonText != null)
            {
                playButonText.font = buttonsFont;
                playButonText.color = textColor;
            }
            if(levelsMenuButtonText != null)
            {
                levelsMenuButtonText.font = buttonsFont;
                levelsMenuButtonText.color = textColor;
            }
            if(backButtonText != null)
            {
                backButtonText.font = buttonsFont;
                backButtonText.color = textColor;
            }
        }
    }

    private void DisableButtonsTexts()
    {
        if (playButonText != null)
        {
            playButonText.gameObject.SetActive(false);
        }
        if (levelsMenuButtonText != null)
        {
            levelsMenuButtonText.gameObject.SetActive(false);
        }
        if (backButtonText != null)
        {
            backButtonText.gameObject.SetActive(false);
        }
    }
}