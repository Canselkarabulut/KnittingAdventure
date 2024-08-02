using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoneButton : MonoBehaviour
{
    public GameObject gameScene;
    public GameObject finishScene;
    public StitchControl stitchControl;
    public GameObject needle;
    public Button star1;
    public Button star2;
    public Button star3;
    public StarControl starControl;
    public static int lastStitchCount;
    public FinishTextControl finishTextControl;
    public FinishStarControl finishStarControl;
    public BonusButton bonusButton;
    public int levelDoneCount;
    public LevelMeneger levelMeneger;
    public List<LevelSelect> listLevelSelect;
 
   

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
        if (starCount > previousStarCount)
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

           // İlgili UI elemanlarını da sıfırla
           listLevelSelect[i].doneLevelControl.gameObject.SetActive(false);
           listLevelSelect[i].doneLevelControl.StarState(0);
       }

       PlayerPrefs.Save();
   }
}