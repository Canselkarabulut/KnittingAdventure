using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour
{
    [SerializeField] private GameObject entryScene;
    [SerializeField] private  GameObject levelScene;
    [SerializeField] private  DoneButton doneButton;
    [SerializeField] private  LevelDiamondControl levelDiamondControl;
    public void PlayBtn()
    {
        doneButton.LoadAllLevelsStatus();
        entryScene.SetActive(false);
        levelScene.SetActive(true);
    }
}