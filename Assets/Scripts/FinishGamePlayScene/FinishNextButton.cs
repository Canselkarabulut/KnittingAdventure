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
    public void FinishNext()
    {
        doneButton.LoadAllLevelsStatus();
        gameFnishScene.SetActive(false);
        levelScene.SetActive(true);
    }
}