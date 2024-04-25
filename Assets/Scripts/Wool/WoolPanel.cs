using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class WoolPanel : MonoBehaviour
{
    public GameObject WoolColorsPanel;
    public Image stitchPrefab;
//    public Color startWoolColor;
    private void Start()
    {
        WoolColorsPanel.SetActive(false);
        stitchPrefab.color =Color.blue;
    }

    public void StitchPanelActive()
    {
        WoolColorsPanel.SetActive(true);
    }

    public void PanelClose()
    {
        WoolColorsPanel.SetActive(false);
    }
    
}