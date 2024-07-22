using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelTextControl : MonoBehaviour
{
    public TextMeshProUGUI diamondCountText;
   
    void Start()
    {
        DiamondCountUpdate();

    }

    public void DiamondCountUpdate()
    {
        //ana menüye dönme çağırıldığında ve nextlenince görmeliyiz
        var diamondCount = PlayerPrefs.GetInt("DiamondCount");
        diamondCountText.text =  diamondCount.ToString();
    }
}
