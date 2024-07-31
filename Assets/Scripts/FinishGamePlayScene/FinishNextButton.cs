using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishNextButton : MonoBehaviour
{
    public GameObject gameFnishScene;
    public GameObject levelScene;
    public LevelTextControl levelTextControl;
    public List<LevelSelect> listLevelSelect;
    public int levelDoneCount;
    private DoneLevelControl doneLevelControl;
    
    public void FinishNext()
    {
    
        levelTextControl.DiamondCountUpdate();
        listLevelSelect[levelDoneCount].LevelVisitControl();
        gameFnishScene.SetActive(false);
        levelScene.SetActive(true);
    }
}