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
    public ParticleSystem star1Effect;
    public ParticleSystem star2Effect;
    public ParticleSystem star3Effect;
    private bool isAnimStar1 = false;
    private bool isAnimStar2 = false;
    private bool isAnimStar3 = false;

    public void StarActive()
    {
        if (stitchControl.trueStitchInt >= 100) 
        {
            star1.interactable = true;
            if (!isAnimStar1)
            {
                star1.GetComponent<Animator>().Play("star1");
                star1Effect.Play();
                isAnimStar1 = true;
            }

            if (stitchControl.trueStitchInt >= 300) 
            {
                star2.interactable = true;
                if (!isAnimStar2)
                {
                    star2.GetComponent<Animator>().Play("star1");
                    star2Effect.Play();
                    isAnimStar2 = true;
                }

                if (stitchControl.trueStitchInt >= 475) 
                {
                    star3.interactable = true;
                    if (!isAnimStar3)
                    {
                        star3.GetComponent<Animator>().Play("star1");
                        star3Effect.Play();
                        isAnimStar3 = true;
                    }
                }
                else
                {
                    star3.interactable = false;
                    isAnimStar3 = false;
                }
            }
            else
            {
                star2.interactable = false;
                isAnimStar2 = false;
            }
        }
        else
        {
            star1.interactable = false;
            isAnimStar1 = false;
        }
    }
}