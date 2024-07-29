using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMeneger : MonoBehaviour
{
    public LevelStatus levelStatus;
    public BackGround desiredStitch;
    public StitchControl stitchControl;
    public static LevelMeneger _instance { get; set; }
public GameObject entryScene;
public GameObject levelScene;
public GameObject gameScene;
public GameObject gaemFinishScene;
    private void Awake()
    {
        SingletonThidGameManager();
    }

    private void Start()
    {
        entryScene.SetActive(true);
        levelScene.SetActive(false);
        gameScene.SetActive(false);
        gaemFinishScene.SetActive(false);
    }

    void SingletonThidGameManager()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void DesiredLevelControl()
    {
        desiredStitch.colorArrayList.Clear();
        stitchControl.stitchCount = 0;

        switch (levelStatus)
        {
            case LevelStatus.Level1:
                desiredStitch.DesiredStitchLevel(0);
                break;
            case LevelStatus.Level2:

                desiredStitch.DesiredStitchLevel(1);
                break;
            case LevelStatus.Level3:
                desiredStitch.DesiredStitchLevel(2);
                break;
            case LevelStatus.Level4:
                desiredStitch.DesiredStitchLevel(3);
                break;
            case LevelStatus.Level5:
                desiredStitch.DesiredStitchLevel(4);
                break;
            case LevelStatus.Level6:
                desiredStitch.DesiredStitchLevel(5);
                break;
            case LevelStatus.Level7:
                desiredStitch.DesiredStitchLevel(6);
                break;
            case LevelStatus.Level8:
                desiredStitch.DesiredStitchLevel(7);
                break;
            case LevelStatus.Level9:
                desiredStitch.DesiredStitchLevel(8);
                break;
            case LevelStatus.Level10:
                desiredStitch.DesiredStitchLevel(9);
                break;
            case LevelStatus.Level11:
                desiredStitch.DesiredStitchLevel(10);
                break;
            case LevelStatus.Level12:
                desiredStitch.DesiredStitchLevel(11);
                break;
            case LevelStatus.Level13:
                desiredStitch.DesiredStitchLevel(12);
                break;
            case LevelStatus.Level14:
                desiredStitch.DesiredStitchLevel(13);
                break;
            case LevelStatus.Level15:
                desiredStitch.DesiredStitchLevel(14);
                break;
            case LevelStatus.Level16:
                desiredStitch.DesiredStitchLevel(15);
                break;
            case LevelStatus.Level17:
                desiredStitch.DesiredStitchLevel(16);
                break;
            case LevelStatus.Level18:
                desiredStitch.DesiredStitchLevel(17);
                break;
            case LevelStatus.Level19:
                desiredStitch.DesiredStitchLevel(18);
                break;
            case LevelStatus.Level20:
                desiredStitch.DesiredStitchLevel(19);
                break;
            case LevelStatus.Level21:
                desiredStitch.DesiredStitchLevel(20);
                break;
            case LevelStatus.Level22:
                desiredStitch.DesiredStitchLevel(21);
                break;
            case LevelStatus.Level23:
                desiredStitch.DesiredStitchLevel(22);
                break;
        }
    }
}