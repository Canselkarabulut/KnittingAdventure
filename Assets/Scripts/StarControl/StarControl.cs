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

    private void Update()
    {
      
    }


    public void StarActive()
    {
        if (stitchControl != null)
        {
            if (stitchControl.stitchCount >= 100)
            {
                star1.interactable = true;
                if (stitchControl.stitchCount >= 300)
                {
                    star2.interactable = true;
                    if (stitchControl.stitchCount >= 450)
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
            else if (stitchControl.stitchCount < 100)
            {
                star1.interactable = false;
            }
        }

    }
}