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
    private void Start()
    {
        entryScene.SetActive(true);
        levelScene.SetActive(false);
        gameScene.SetActive(false);
        gaemFinishScene.SetActive(false);
    }
    public void DesiredLevelControl()
    {
        desiredStitch.colorArrayList.Clear();
        stitchControl.stitchCount = 0;
        desiredStitch.DesiredStitchLevel((int)levelStatus);
    }
}