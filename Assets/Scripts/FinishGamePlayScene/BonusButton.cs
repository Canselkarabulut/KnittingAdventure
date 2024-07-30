using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BonusButton : MonoBehaviour
{
    public LevelMeneger levelMeneger;
    public TextMeshProUGUI bonusText;
    private int baseBonus;


    public void BonusText()
    {
        baseBonus = 500;
        int level = (int)levelMeneger.levelStatus;
        int bonus = baseBonus + (level * 100);
        bonusText.text = "+" + bonus.ToString();
    }
}