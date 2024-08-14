using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMeneger : MonoBehaviour
{
    
    [SerializeField] public LevelStatus levelStatus;
    [SerializeField] private  BackGround desiredStitch;
    [SerializeField] private  StitchControl stitchControl;
    [SerializeField] private  GameObject entryScene;
    [SerializeField] private  GameObject levelScene;
    [SerializeField] private  GameObject gameScene;
    [SerializeField] private  GameObject gaemFinishScene;
    private  static LevelMeneger _instance { get; set; }

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