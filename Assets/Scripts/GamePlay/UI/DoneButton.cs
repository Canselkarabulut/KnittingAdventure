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
    public List<int> listStarCount;

  
    public void Done()
    {
        foreach (Transform child in stitchControl.transform)
        {
            Destroy(child.gameObject);
        }

        levelDoneCount = (int)levelMeneger.levelStatus; // bulunduğum levelin sayısı
        listLevelSelect[levelDoneCount].doneLevelControl.gameObject.SetActive(true);
        listLevelSelect[levelDoneCount].doneLevelControl.StarState(starControl.starCount);
        listStarCount[levelDoneCount] = starControl.starCount;


        PlayerPrefs.SetInt("lastStarCount", starControl.starCount); // yıldız sayısı


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
}