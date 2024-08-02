using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour
{
    public GameObject entryScene;
    public GameObject levelScene;
    public DoneButton doneButton;
    public LevelDiamondControl levelDiamondControl;
    public void PlayBtn()
    {
        doneButton.LoadAllLevelsStatus();
        entryScene.SetActive(false);
        levelScene.SetActive(true);
    }
}