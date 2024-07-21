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

   // public GameObject needleEffect1;
   // public GameObject needleEffect2;
   // public GameObject stitchArrowEffect;
   // public GameObject miniImageEffectParent;
//
   // private void Start()
   // {
   //     EffectOnOff(false, false, false, false);
   // }
//
   // public void EffectOnOff( bool needle1, bool needle2,bool stitchArrow,bool miniImageParent)
   // {
   //     needleEffect1.SetActive(needle1);
   //     needleEffect2.SetActive(needle2);
   //     stitchArrowEffect.SetActive(stitchArrow);
   //     miniImageEffectParent.SetActive(miniImageParent);
   //     
   //     
   // }
}