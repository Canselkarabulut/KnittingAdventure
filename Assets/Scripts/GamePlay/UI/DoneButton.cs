using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DoneButton : MonoBehaviour
{
    [SerializeField] private GameObject gameScene;
    [SerializeField] private GameObject finishScene;
    [SerializeField] private StitchControl stitchControl;
    [SerializeField] private GameObject needle;
    [SerializeField] private Button star1;
    [SerializeField] private Button star2;
    [SerializeField] private Button star3;
    [SerializeField] private StarControl starControl;
    [SerializeField] public static int lastStitchCount;
    [SerializeField] private FinishTextControl finishTextControl;
    [SerializeField] private FinishStarControl finishStarControl;
    [SerializeField] private BonusButton bonusButton;
    [SerializeField] public int levelDoneCount;
    [SerializeField] private LevelMeneger levelMeneger;
    [SerializeField] private List<LevelSelect> listLevelSelect;


    public void Done()
    {
        levelDoneCount = (int)levelMeneger.levelStatus; // bulunduğum levelin sayısı
        listLevelSelect[levelDoneCount].doneLevelControl.gameObject.SetActive(true);
        listLevelSelect[levelDoneCount].doneLevelControl.StarState(starControl.starCount);

        OnLevelCompleted(levelDoneCount, starControl.starCount);
        PlayerPrefs.SetInt("lastStarCount", starControl.starCount); // yıldız sayısı

        foreach (Transform child in stitchControl.transform)
        {
            Destroy(child.gameObject);
        }

        lastStitchCount = stitchControl.trueStitchInt;
        stitchControl.i = 0;
        stitchControl.j = 0;
        stitchControl.trueStitchInt = 0;
        needle.transform.position = new Vector3(stitchControl.firstNeedleX, stitchControl.firstNeedleY,
            needle.transform.position.z);
        star1.interactable = false;
        star2.interactable = false;
        star3.interactable = false;
        gameObject.SetActive(false);
        gameScene.SetActive(false);
        finishScene.SetActive(true);
        finishTextControl.isClick = false;
        finishTextControl.Conclusion();
        finishStarControl.StarActiveWait();
        bonusButton.BonusText();
    }

    public void SaveLevelStatus(int levelIndex, int starCount)
    {
        // Seviye tamamlandı durumunu kaydet
        PlayerPrefs.SetInt("Level_" + levelIndex + "_Completed", 1);
        // Kazanılan yıldız sayısını kaydet
        int previousStarCount = PlayerPrefs.GetInt("Level_" + levelIndex + "_Stars", 0);
        if (starCount >= previousStarCount)
        {
            PlayerPrefs.SetInt("Level_" + levelIndex + "_Stars", starCount);
        }

        PlayerPrefs.Save();
    }

    void LoadLevelStatus(int levelIndex)
    {
        // Seviye tamamlandı mı?
        bool isLevelCompleted = PlayerPrefs.GetInt("Level_" + levelIndex + "_Completed", 0) == 1;

        // Kazanılan yıldız sayısı
        int starCount = PlayerPrefs.GetInt("Level_" + levelIndex + "_Stars", 0);

        // Level kontrolünü ve yıldız durumunu ayarla
        if (isLevelCompleted)
        {
            listLevelSelect[levelIndex].doneLevelControl.gameObject.SetActive(true);
            listLevelSelect[levelIndex].doneLevelControl.StarState(starCount);
        }
    }

    public void OnLevelCompleted(int levelIndex, int starCount)
    {
        SaveLevelStatus(levelIndex, starCount);
        LoadLevelStatus(levelIndex);
    }

    public void LoadAllLevelsStatus()
    {
        for (int i = 0; i < listLevelSelect.Count; i++)
        {
            LoadLevelStatus(i);
        }
    }

    public void ResetAllLevelsStatus()
    {
        for (int i = 0; i < listLevelSelect.Count; i++)
        {
            PlayerPrefs.DeleteKey("Level_" + i + "_Completed");
            PlayerPrefs.DeleteKey("Level_" + i + "_Stars");
            if (i > 0)
            {
                PlayerPrefs.DeleteKey("LockLevel_" + i + "_UnLockCount");
                listLevelSelect[i].lockPanel.SetActive(true);
            }

            // İlgili UI elemanlarını da sıfırla
            listLevelSelect[i].doneLevelControl.gameObject.SetActive(false);
            listLevelSelect[i].doneLevelControl.StarState(0);
        }

        PlayerPrefs.Save();
    }
}