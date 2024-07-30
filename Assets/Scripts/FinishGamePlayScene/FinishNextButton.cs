using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishNextButton : MonoBehaviour
{
    public GameObject gameFnishScene;
    public GameObject levelScene;
    public LevelMeneger levelMeneger;
    public LevelTextControl levelTextControl;
    public List<LevelSelect> listLevelSelect;
    public StarControl starControl;
    public DoneButton doneButton;
    private DoneLevelControl doneLevelControl;


    public void FinishNext()
    {
        doneButton.levelDoneCount = (int)levelMeneger.levelStatus;
        levelTextControl.DiamondCountUpdate();
        PlayerPrefs.SetInt("LevelDoneCount", doneButton.levelDoneCount);
        listLevelSelect[doneButton.levelDoneCount].LevelVisitControl();
        
        
        //doneLevelControl = listLevelSelect[doneButton.levelDoneCount].GetComponentInChildren<DoneLevelControl>();
       // doneLevelControl.donePanelActivecountbool = 1;
       // PlayerPrefs.SetInt("dlc", doneLevelControl.donePanelActivecountbool);
       // doneLevelControl.StarState(starControl.starCount);
       // PlayerPrefs.SetInt("sc", starControl.starCount);

        gameFnishScene.SetActive(false);
        levelScene.SetActive(true);
    }
}