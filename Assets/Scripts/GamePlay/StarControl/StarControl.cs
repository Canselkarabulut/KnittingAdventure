using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarControl : MonoBehaviour
{
    
    [SerializeField] private  StitchControl stitchControl;
    [SerializeField] private  Button star1;
    [SerializeField] private  Button star2;
    [SerializeField] private  Button star3;
    [SerializeField] private  ParticleSystem star1Effect;
    [SerializeField] private  ParticleSystem star2Effect;
    [SerializeField] private  ParticleSystem star3Effect;
    [SerializeField] private  GameObject doneButton;
    [SerializeField] public  int starCount;
    private bool isAnimStar1 = false;
    private bool isAnimStar2 = false;
    private bool isAnimStar3 = false;
    
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
            doneButton.SetActive(false);
            isAnimStar1 = false;
            starCount = 0;
        }
    }
}