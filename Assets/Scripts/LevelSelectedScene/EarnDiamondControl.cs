using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnDiamondControl : MonoBehaviour
{
    public Image activeAgainImage;
    public GameObject levelScenePanel;
    private float timeSpeed=.00005f;
    public Button earnDiamondButton;
  
    private void Start()
    {
         activeAgainImage.fillAmount = 0;
         earnDiamondClickCount = PlayerPrefs.GetInt("earnDiamondClickCount");
    }

    private void Update()
    {
        ActiveTime();
    }

    private float time;

    public void ActiveTime()
    {
        if (levelScenePanel.activeInHierarchy)
        {
            time += Time.deltaTime;
            if (activeAgainImage.fillAmount > .01)
            {
                activeAgainImage.fillAmount -= time * timeSpeed;
                earnDiamondButton.interactable = false;
            }
            else
            {
                earnDiamondButton.interactable = true;
            }
        }
    }

    public int earnDiamondClickCount;
    public void EarnDiamonfButton()
    {
        earnDiamondClickCount++;
        Debug.Log("earnDiamondClickCount: "+earnDiamondClickCount);
        PlayerPrefs.SetInt("earnDiamondClickCount",earnDiamondClickCount);
        if (earnDiamondClickCount < 6)
        {
            activeAgainImage.fillAmount = 1;
        }
        else
        {
            earnDiamondButton.interactable = false;
        }
        
        
    }
}