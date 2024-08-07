using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishNextButton : MonoBehaviour
{
    public GameObject gameFnishScene;

    public GameObject levelScene;
    public DoneButton doneButton;
    public LevelTextControl levelTextControl;
    public EarnDiamondControl earnDiamondControl;
    public void FinishNext()
    {
        earnDiamondControl.earnDiamondClickCount = 0;
       PlayerPrefs.SetInt("earnDiamondClickCount",0);
        doneButton.LoadAllLevelsStatus();
        levelTextControl.DiamondCountUpdate();
        gameFnishScene.SetActive(false);
        levelScene.SetActive(true);
    }
}