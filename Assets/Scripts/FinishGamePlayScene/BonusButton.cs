using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BonusButton : MonoBehaviour
{
    [SerializeField] private LevelMeneger levelMeneger;
    [SerializeField] private TextMeshProUGUI bonusText;
    [SerializeField] private TextMeshProUGUI conclusionText;
    [SerializeField] private int lastBonus;
    [SerializeField] private FinishTextControl finishTextControl;
    [SerializeField] private LevelTextControl levelTextControl; //elmas güncelleme
    [SerializeField] private int updateDiamondCount;
    private int baseBonus;
    
    public void BonusText()
    {
        baseBonus = 500;
        int level = (int)levelMeneger.levelStatus;
        lastBonus = baseBonus + (level * 100);
        bonusText.text = "+" + lastBonus.ToString();
    }
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