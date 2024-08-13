using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EarnDiamondControl : MonoBehaviour
{
    public Image activeAgainImage;
    public GameObject levelScenePanel;
    private float timeSpeed=.00005f;
    public Button earnDiamondButton;
    private int maxClick = 3;
    private void Start()
    {
         activeAgainImage.fillAmount = 0;
         earnDiamondClickCount = PlayerPrefs.GetInt("earnDiamondClickCount");
         if ( PlayerPrefs.GetInt("earnDiamondClickCount") >=maxClick)
         {
             earnDiamondButton.interactable = false;
         }
         else
         {
             earnDiamondButton.interactable = true;
         }
    }

    private void Update()
    {
            ActiveTime();
    }

    private float time;

    public void ActiveTime()
    {
        if (isClick)
        {
            if (levelScenePanel.activeInHierarchy)
            {
                time += Time.deltaTime;
                if (activeAgainImage.fillAmount < .999)
                {
                    activeAgainImage.fillAmount += time * timeSpeed;
                    earnDiamondButton.interactable = false;
                }
                else
                {
                    earnDiamondButton.interactable = true;
                    activeAgainImage.fillAmount = 0;
                    isClick = false;
                }
            }
        }
      
    }

    public int earnDiamondClickCount;
    public bool isClick;
    private int updateDiamondCount;
    public int addDiamond = 250;
    public LevelTextControl levelTextControl;
    public void EarnDiamonfButton()
    {
       
        earnDiamondClickCount++;
        PlayerPrefs.SetInt("earnDiamondClickCount",earnDiamondClickCount);
        if (earnDiamondClickCount < maxClick)
        {
            activeAgainImage.fillAmount = 0;
            isClick = true;
        }
        else
        {
            earnDiamondButton.interactable = false;
        }
        
        updateDiamondCount = PlayerPrefs.GetInt("DiamondCount");
        //günceldeki param getirildi
        updateDiamondCount += addDiamond; // bonus paramı ekle
        PlayerPrefs.SetInt("DiamondCount",updateDiamondCount); // yeni paramı kaydet
        levelTextControl.DiamondCountUpdate();
    }
}