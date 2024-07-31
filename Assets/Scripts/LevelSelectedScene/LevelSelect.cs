using System;
using System.Collections;
using System.Collections.Generic;
using GamePlay.Enum;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public GameObject levelScene;
    public GameObject gameScene;
    public GameObject lockPanel;
    public LevelCount levelCount;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public LevelMeneger levelMeneger;
    public StitchControl stitchControl;
   
    public StarControl starControl;
    public DoneLevelControl doneLevelControl;
    public DoneActiveState doneActiveState = DoneActiveState.False;
    private int doneint = 0;
    
    public void LevelVisitControl()
    {
        doneLevelControl.DonePanelActiveCount();
     
       // doneLevelControl.gameObject.SetActive(true);
        
        Star1.SetActive(starControl.starCount >= 1);
        Star2.SetActive(starControl.starCount >= 2);
        Star3.SetActive(starControl.starCount >= 3);
    }

    public void LevelSceneSelect()
    {
        if (!lockPanel.gameObject.activeInHierarchy)
        {
            Selected(levelCount);
            doneActiveState = DoneActiveState.True;
            doneint = 1;
            PlayerPrefs.SetInt("doneint",doneint);
        }
    }

    public void Selected(LevelCount levelCount)
    {
        switch (levelCount)
        {
            case LevelCount.lvl1:
                LevelControl(LevelStatus.Level1);
                break;
            case LevelCount.lvl2:
                LevelControl(LevelStatus.Level2);
                break;
            case LevelCount.lvl3:
                LevelControl(LevelStatus.Level3);
                break;
            case LevelCount.lvl4:
                LevelControl(LevelStatus.Level4);
                break;
            case LevelCount.lvl5:
                LevelControl(LevelStatus.Level5);
                break;
            case LevelCount.lvl6:
                LevelControl(LevelStatus.Level6);
                break;
            case LevelCount.lvl7:
                LevelControl(LevelStatus.Level7);
                break;
            case LevelCount.lvl8:
                LevelControl(LevelStatus.Level8);
                break;
            case LevelCount.lvl9:
                LevelControl(LevelStatus.Level9);
                break;
            case LevelCount.lvl10:
                LevelControl(LevelStatus.Level10);
                break;
            case LevelCount.lvl11:
                LevelControl(LevelStatus.Level11);
                break;
            case LevelCount.lvl12:
                LevelControl(LevelStatus.Level12);
                break;
            case LevelCount.lvl13:
                LevelControl(LevelStatus.Level13);
                break;
            case LevelCount.lvl14:
                LevelControl(LevelStatus.Level14);
                break;
            case LevelCount.lvl15:
                LevelControl(LevelStatus.Level15);
                break;
            case LevelCount.lvl16:
                LevelControl(LevelStatus.Level16);
                break;
            case LevelCount.lvl17:
                LevelControl(LevelStatus.Level17);
                break;
            case LevelCount.lvl18:
                LevelControl(LevelStatus.Level18);
                break;
            case LevelCount.lvl19:
                LevelControl(LevelStatus.Level19);
                break;
            case LevelCount.lvl20:
                LevelControl(LevelStatus.Level20);
                break;
            case LevelCount.lvl21:
                LevelControl(LevelStatus.Level21);
                break;
            case LevelCount.lvl22:
                LevelControl(LevelStatus.Level22);
                break;
            case LevelCount.lvl23:
                LevelControl(LevelStatus.Level23);
                break;
        }
    }


    public void LevelControl(LevelStatus level)
    {
        levelMeneger.levelStatus = level;
        levelScene.SetActive(false);
        gameScene.SetActive(true);
        levelMeneger.DesiredLevelControl();
        stitchControl.StartPixelColor();
    }
}