using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject settingPanel;
    public Button stitchArroeButton;
    public Button undostitchArroeButton;
    
    private void Start()
    {
        settingPanel.SetActive(false);
    }

    public void SettingButton()
    {
        
        settingPanel.SetActive(true);
        this.gameObject.GetComponent<Button>().interactable = false;
        stitchArroeButton.interactable = false;
        undostitchArroeButton.interactable = false;
    }


    public void CloseSettingPanel()
    {
        this.gameObject.GetComponent<Button>().interactable = true;
        stitchArroeButton.interactable = true;
        undostitchArroeButton.interactable = true;
        settingPanel.SetActive(false);
    }
}
