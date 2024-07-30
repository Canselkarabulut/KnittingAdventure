using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoneLevelControl : MonoBehaviour
{
    public int donePanelActivecountbool;
    public int doneStarCount;
    public GameObject gameStar1;
    public GameObject gameStar2;
    public GameObject gameStar3;

    public void DonePanelActiveCount()
    {
        donePanelActivecountbool = 1;
    }

    public void StarState(int starCount)
    {
        switch (starCount)
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

    public void StarActive(bool star1, bool star2, bool star3)
    {
        gameStar1.SetActive(star1);
        gameStar2.SetActive(star2);
        gameStar3.SetActive(star3);
    }
}