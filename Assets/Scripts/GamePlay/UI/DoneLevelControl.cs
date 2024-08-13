using System;
using System.Collections;
using System.Collections.Generic;
using GamePlay.Enum;
using UnityEngine;

public class DoneLevelControl : MonoBehaviour
{
    [SerializeField] private int donePanelActivecountbool;
    [SerializeField] private GameObject gameStar1;
    [SerializeField] private GameObject gameStar2;
    [SerializeField] private GameObject gameStar3;
    [SerializeField] private DoneActiveState doneActiveState;


    public int DonePanelActiveCount()
    {
        doneActiveState = DoneActiveState.True;
        return donePanelActivecountbool = 1;
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