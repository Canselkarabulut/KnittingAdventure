using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelTextControl : MonoBehaviour
{
    public TextMeshProUGUI diamondCountText;
   
    void Start()
    {
        diamondCountText.text =  PlayerPrefs.GetInt("DiamondCount").ToString();
    }

    void Update()
    {
        
    }
}
