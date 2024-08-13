using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialShowControl : MonoBehaviour
{
    private int gameShowCount = 0;
    private bool isTwoTutorial;

    public GameObject tutorialOne;
    public GameObject tutorialTwo;
    public GameObject tutorialTree;

    void Start()
    {
        gameShowCount = PlayerPrefs.GetInt("gameShowCount", 0) + 1;
        PlayerPrefs.SetInt("gameShowCount", gameShowCount);
        Debug.Log(gameShowCount);
        isTwoTutorial = false;
        isDifferentColor = false;
    }

    public void TutorialOne()
    {
        if (gameShowCount < 2)
        {
            tutorialOne.SetActive(true);
        }
        else
        {
            tutorialOne.SetActive(false);
            PlayerPrefs.SetInt("gameShowCount", 3);
        }
    }

    public void TutorialOneClick()
    {
        tutorialOne.SetActive(false);
        TutorialTwo();
    }

    public void TutorialTwo()
    {
        tutorialTwo.SetActive(true);
    }

    public void TutorialTwoClick()
    {
        if (!isTwoTutorial)
        {
            tutorialTwo.SetActive(false);
            isTwoTutorial = false;
        }
    }

    private bool isDifferentColor = false;

    public void TutorialTree(Color32 nowImage, Color32 before1Image)
    {
        if (gameShowCount < 2)
        {
            if (nowImage.a == before1Image.a && nowImage.r == before1Image.r && nowImage.g == before1Image.g &&
                nowImage.b == before1Image.b)
            {
            }
            else
            {
                if (!isDifferentColor)
                {
                    Time.timeScale = 0;
                    tutorialTree.SetActive(true);
                    isDifferentColor = true;
                }
            }
        }
    }

    public void TutorialTreeClick()
    {
        Time.timeScale = 1;
        tutorialTree.SetActive(false);
    }
}