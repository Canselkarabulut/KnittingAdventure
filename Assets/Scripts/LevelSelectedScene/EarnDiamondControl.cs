using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EarnDiamondControl : MonoBehaviour
{
    [SerializeField] private Image activeAgainImage;
    [SerializeField] private GameObject levelScenePanel;
    [SerializeField] public Button earnDiamondButton;
    [SerializeField] public int earnDiamondClickCount;
    [SerializeField] private  bool isClick;
    [SerializeField] private  int addDiamond = 250;
    [SerializeField] private  LevelTextControl levelTextControl;
    private int maxClick = 3;
    private float time;
    private float timeSpeed=.00005f;
    private int updateDiamondCount;
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