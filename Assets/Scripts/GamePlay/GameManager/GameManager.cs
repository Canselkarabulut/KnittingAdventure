using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Singelton

    public static GameManager _instance { get; set; }

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

    #endregion

 
  
}