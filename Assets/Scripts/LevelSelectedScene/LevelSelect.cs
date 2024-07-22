using System;
using System.Collections;
using System.Collections.Generic;
using GamePlay.Enum;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private void Start()
    {
        LevelVizitControl();
    }

    public void LevelVizitControl()
    {
        switch (FinishNextButton.levelDoneCount)
        {
            case 1:
                if (levelCount == LevelCount.lvl1)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true); // lock paneli aç
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 2:
                if (levelCount == LevelCount.lvl2)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 3:
                if (levelCount == LevelCount.lvl3)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);  
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 4:
                if (levelCount == LevelCount.lvl4)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 5:
                if (levelCount == LevelCount.lvl5)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 6:
                if (levelCount == LevelCount.lvl6)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 7:
                if (levelCount == LevelCount.lvl7)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 8:
                if (levelCount == LevelCount.lvl8)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 9:
                if (levelCount == LevelCount.lvl9)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 10:
                if (levelCount == LevelCount.lvl10)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 11:
                if (levelCount == LevelCount.lvl11)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 12:
                if (levelCount == LevelCount.lvl12)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 13:
                if (levelCount == LevelCount.lvl13)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 14:
                if (levelCount == LevelCount.lvl14)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 15:
                if (levelCount == LevelCount.lvl15)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 16:
                if (levelCount == LevelCount.lvl16)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 17:
                if (levelCount == LevelCount.lvl17)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 18:
                if (levelCount == LevelCount.lvl18)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 19:
                if (levelCount == LevelCount.lvl19)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }

                break;
            case 20:
                if (levelCount == LevelCount.lvl20)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }
                break;
            case 21:
                if (levelCount == LevelCount.lvl21)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }
                break;
            case 22:
                if (levelCount == LevelCount.lvl22)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }
                break;
            case 23:
                if (levelCount == LevelCount.lvl23)
                {
                    transform.GetChild(transform.childCount - 1).gameObject.SetActive(true);
                    if (DoneButton.lastStarCount == 1)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(false);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 2)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(false);
                    }
                    if (DoneButton.lastStarCount == 3)
                    {
                        Star1.SetActive(true);
                        Star2.SetActive(true);
                        Star3.SetActive(true);
                    }
                }
                break;
        } 
    }
    public void LevelSceneSelect()
    {
        if (!lockPanel.gameObject.activeInHierarchy)
        {
            Selected(levelCount);
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
        levelMeneger.levelStatus  = level;
        levelScene.SetActive(false);
        gameScene.SetActive(true);
        levelMeneger.DesiredLevelControl();
        stitchControl.StartPixelColor();
       
    }
}