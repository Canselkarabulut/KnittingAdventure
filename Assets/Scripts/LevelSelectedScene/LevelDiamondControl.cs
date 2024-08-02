using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelDiamondControl : MonoBehaviour
{

    private int baseBonus;
    //public LevelMeneger levelMeneger;
    public int lastBonus;
    public LevelSelect levelSelect;
    public TextMeshProUGUI diamondText;
    private int levelUnlockDiamond;
    private void Start()
    {
        DiamondCalculation();
    }

    public void DiamondCalculation()
    {
        baseBonus = 500;
        int levelIndex = (int)levelSelect.levelCount;
        lastBonus = baseBonus + (levelIndex * 100);
        if((Convert.ToInt32(levelIndex/2)>0))
        {
            levelUnlockDiamond = ((484 * 3)*Convert.ToInt32(levelIndex/2)) + (lastBonus / 2);
        }
        else
        {
            levelUnlockDiamond = ((484 * 3)*Convert.ToInt32(levelIndex)) + (lastBonus / 2);
        }
        
        if (diamondText != null)
        {
            diamondText.text = levelUnlockDiamond.ToString();
           
        }
    }
}
