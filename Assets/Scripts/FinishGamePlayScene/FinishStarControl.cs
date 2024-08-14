using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishStarControl : MonoBehaviour
{
    [SerializeField] private GameObject star1;
    [SerializeField] private GameObject star2;
    [SerializeField] private GameObject star3;
    [SerializeField] private StarControl starControl;

    private void Start()
    {
        StarActive(false, false, false);
        StarActiveWait();
    }

    public void StarActiveWait()
    {
        switch (starControl.starCount)
        {
            case 0:
                StarActive(false, false, false);
                break;
            case 1:
                StarActive(true, false, false);
                break;
            case 2:
                StarActive(true, true, false);
                break;
            case 3:
                StarActive(true, true, true);
                break;
        }
    }

    public void StarActive(bool star1bool, bool star2bool, bool star3bool)
    {
        star1.SetActive(star1bool);
        if (star1bool)
        {
            star1.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
        }

        star2.SetActive(star2bool);
        if (star2bool)
        {
            star2.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
        }

        star3.SetActive(star3bool);
        if (star3bool)
        {
            star3.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
        }
    }
}