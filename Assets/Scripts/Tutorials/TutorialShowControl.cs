using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialShowControl : MonoBehaviour
{
    private int gameShowCount = 0;
    public GameObject gameScene;
    public GameObject tutorialOne;
    public GameObject tutorialTwo;
    private bool isTwoTutorial;

    void Start()
    {
        gameShowCount = PlayerPrefs.GetInt("gameShowCount", 0) + 1;
        PlayerPrefs.SetInt("gameShowCount", gameShowCount);
        Debug.Log(gameShowCount);
        isTwoTutorial = false;
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
}