//using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIController : MonoBehaviour
{
    [Header("Blocks"), SerializeField]
    private GameObject menuUI;
    [SerializeField]
    private GameObject levelsMenuUI;

    [Header("Components"), SerializeField]
    private RectTransform levelsContent;
    [SerializeField]
    private ImagesController imagesController;

    [Header("Prefabs"), SerializeField]
    private LevelButtonController levelButtonPrefab;

    [Header("Variables"), /*Scene,*/ SerializeField]
    private int firstLevelScene;

    private List<int> levelsBuildIndexes = new List<int>();

    private void Start()
    {
        ShowMenu();

        GenerateLevelButtons();
    }

    #region Clicked

    public void OnStartClicked()
    {
        SceneManager.LoadSceneAsync(levelsBuildIndexes.First());
    }

    public void OnLevelsClicked()
    {
        ShowLevelsMenu();
    }

    public void OnBackToMenuClicked()
    {
        ShowMenu();
    }

    #endregion

    #region Show

    private void ShowMenu()
    {
        menuUI.SetActive(true);

        levelsMenuUI.SetActive(false);
    }

    private void ShowLevelsMenu()
    {
        menuUI.SetActive(false);

        levelsMenuUI.SetActive(true);
    }

    #endregion

    private void GenerateLevelButtons()
    {
        foreach (var levelButton in levelsContent.GetComponentsInChildren<LevelButtonController>())
        {
            Destroy(levelButton.gameObject);
        }

        if (levelsBuildIndexes.Count == 0)
        {
            GetLevelsBuildIndexes();
        }

        for (int i = 0; i < levelsBuildIndexes.Count(); i++)
        {
            var newLevelButton = Instantiate(levelButtonPrefab, levelsContent);
            newLevelButton.Set(levelsBuildIndexes[i], imagesController.GetTextColor(), imagesController.GetFont(), imagesController.GetLevelButtonSprite());
        }
    }

    private void GetLevelsBuildIndexes()
    {
        for (int i = firstLevelScene + 1; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            levelsBuildIndexes.Add(i);
        }
    }
}