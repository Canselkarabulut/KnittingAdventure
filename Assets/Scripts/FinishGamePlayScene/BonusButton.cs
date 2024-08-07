using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BonusButton : MonoBehaviour
{
    public LevelMeneger levelMeneger;
    public TextMeshProUGUI bonusText;
    public TextMeshProUGUI conclusionText;
    private int baseBonus;
    public int lastBonus;
    public FinishTextControl finishTextControl;
    public void BonusText()
    {
        baseBonus = 500;
        int level = (int)levelMeneger.levelStatus;
        lastBonus = baseBonus + (level * 100);
        bonusText.text = "+" + lastBonus.ToString();
    }
    public LevelTextControl levelTextControl; //elmas güncelleme
    public int updateDiamondCount;

    public void BonusButtonClick()
    {
        levelTextControl.DiamondCountUpdate();
        conclusionText.text = (finishTextControl.conclusion + lastBonus).ToString();
        updateDiamondCount = PlayerPrefs.GetInt("DiamondCount");
        //günceldeki param getirildi
        updateDiamondCount += lastBonus; // bonus paramı ekle
        PlayerPrefs.SetInt("DiamondCount",updateDiamondCount); // yeni paramı kaydet
        gameObject.SetActive(false);
        conclusionText.GetComponent<Animator>().Play("bonusButtonAnim");
        
    }
        
}