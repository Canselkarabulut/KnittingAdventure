using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishNextButton : MonoBehaviour
{
    [SerializeField] private GameObject gameFnishScene;
    [SerializeField] private GameObject levelScene;
    [SerializeField] private DoneButton doneButton;
    [SerializeField] private LevelTextControl levelTextControl;
    [SerializeField] private EarnDiamondControl earnDiamondControl;

    public void FinishNext()
    {
        earnDiamondControl.earnDiamondClickCount = 0;
        earnDiamondControl.earnDiamondButton.interactable = true;
        PlayerPrefs.SetInt("earnDiamondClickCount", 0);
        doneButton.LoadAllLevelsStatus();
        levelTextControl.DiamondCountUpdate();
        gameFnishScene.SetActive(false);
        levelScene.SetActive(true);
    }
}