using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public static LoadScene _instance { get; set; }
    public static BackGround desiredStitch;
    public static StitchControl stitchControl;
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
        StartCoroutine(WiatStart());
    }

    IEnumerator WiatStart()
    {
        yield return new WaitForSeconds(.0009f);
        desiredStitch = GameObject.FindObjectOfType<BackGround>();
        stitchControl = GameObject.FindObjectOfType<StitchControl>();
    }
}
