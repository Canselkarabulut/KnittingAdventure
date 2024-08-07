using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnDiamondControl : MonoBehaviour
{
    public Image activeAgainImage;
    public GameObject levelScenePanel;
    public float timeSpeed=.01f;
    private void Start()
    {
        // activeAgainImage.fillAmount = 0;
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
            }
        }
    }
}