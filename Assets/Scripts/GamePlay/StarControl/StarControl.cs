using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarControl : MonoBehaviour
{
    public StitchControl stitchControl;
    public Button star1;
    public Button star2;
    public Button star3;

    public void StarActive()
    {
        if (stitchControl.trueStitchInt >= 100)
        {
            star1.interactable = true;
            if (stitchControl.trueStitchInt >= 300)
            {
                star2.interactable = true;
                if (stitchControl.trueStitchInt >= 475)
                {
                    star3.interactable = true;
                }
                else
                {
                    star3.interactable = false;
                }
            }
            else
            {
                star2.interactable = false;
            }
        }
        else
        {
            star1.interactable = false;
        }
    }
}