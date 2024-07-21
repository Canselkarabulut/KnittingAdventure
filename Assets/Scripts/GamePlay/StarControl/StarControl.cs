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
    public GameObject doneButton;
    public int starCount;
    private void Start()
    {
        doneButton.SetActive(false);
    }

    public void StarActive()
    {
        if (stitchControl.trueStitchInt >= 100) 
        {
            star1.interactable = true;
            starCount = 1;
            doneButton.SetActive(true);
            if (!isAnimStar1)
            {
                star1.GetComponent<Animator>().Play("star1");
                star1Effect.Play();
                isAnimStar1 = true;
            }

            if (stitchControl.trueStitchInt >= 300) 
            {
                star2.interactable = true;
                starCount = 2;
                if (!isAnimStar2)
                {
                    star2.GetComponent<Animator>().Play("star1");
                    star2Effect.Play();
                    isAnimStar2 = true;
                }

                if (stitchControl.trueStitchInt >= 475) 
                {
                    star3.interactable = true;
                    starCount = 3;
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
                    starCount = 2;
                }
            }
            else
            {
                star2.interactable = false;
                isAnimStar2 = false;
                starCount = 1;
            }
        }
        else
        {
            star1.interactable = false;
            isAnimStar1 = false;
            starCount = 0;
        }
    }
}