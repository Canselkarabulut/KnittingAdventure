using System;
using System.Collections;
using System.Collections.Generic;
using GamePlay.Enum;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject lockPanel;
    public LevelCount levelCount;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    private void Start()
    {
        switch (FinishNextButton.levelDoneCount)
        {
            case 1:
                if (levelCount == LevelCount.lvl1)
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
                LevelMeneger.levelStatus = LevelStatus.Level1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl2:
                LevelMeneger.levelStatus = LevelStatus.Level2;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl3:
                LevelMeneger.levelStatus = LevelStatus.Level3;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl4:
                LevelMeneger.levelStatus = LevelStatus.Level4;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl5:
                LevelMeneger.levelStatus = LevelStatus.Level5;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl6:
                LevelMeneger.levelStatus = LevelStatus.Level6;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl7:
                LevelMeneger.levelStatus = LevelStatus.Level7;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl8:
                LevelMeneger.levelStatus = LevelStatus.Level8;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl9:
                LevelMeneger.levelStatus = LevelStatus.Level9;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl10:
                LevelMeneger.levelStatus = LevelStatus.Level10;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl11:
                LevelMeneger.levelStatus = LevelStatus.Level11;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl12:
                LevelMeneger.levelStatus = LevelStatus.Level12;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl13:
                LevelMeneger.levelStatus = LevelStatus.Level13;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl14:
                LevelMeneger.levelStatus = LevelStatus.Level14;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl15:
                LevelMeneger.levelStatus = LevelStatus.Level15;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl16:
                LevelMeneger.levelStatus = LevelStatus.Level16;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl17:
                LevelMeneger.levelStatus = LevelStatus.Level17;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl18:
                LevelMeneger.levelStatus = LevelStatus.Level18;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl19:
                LevelMeneger.levelStatus = LevelStatus.Level19;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl20:
                LevelMeneger.levelStatus = LevelStatus.Level20;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl21:
                LevelMeneger.levelStatus = LevelStatus.Level21;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl22:
                LevelMeneger.levelStatus = LevelStatus.Level22;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case LevelCount.lvl23:
                LevelMeneger.levelStatus = LevelStatus.Level23;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
        }
    }
}