using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialShowControl : MonoBehaviour
{
    private int gameShowCount=0;
    void Start()
    {
        gameShowCount += PlayerPrefs.GetInt("gameShowCount", 0);
        PlayerPrefs.SetInt("gameShowCount",gameShowCount);
        Debug.Log(PlayerPrefs.GetInt("gameShowCount"));
       
    }
    void Update()
    {
        
    }
}
