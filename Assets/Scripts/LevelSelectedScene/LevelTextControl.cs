using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelTextControl : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI diamondCountText;
   
    void Start()
    {
        DiamondCountUpdate();

    }
    public void DiamondCountUpdate()
    {
        var diamondCount = PlayerPrefs.GetInt("DiamondCount");
        diamondCountText.text =  diamondCount.ToString();
    }
}
