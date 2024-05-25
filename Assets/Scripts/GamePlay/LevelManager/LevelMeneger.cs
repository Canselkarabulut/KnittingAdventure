using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMeneger : MonoBehaviour
{
    public LevelStatus levelStatus;

    public BackGround desiredStitch;
    public StitchControl stitchControl;

    private void Start()
    {
        DesiredLevelControl();
       
    }
    public void DesiredLevelControl()
    {
        desiredStitch.colorArrayList.Clear();
        stitchControl.stitchCount = 0;
        switch (levelStatus)
        {
            case LevelStatus.Level1:
               desiredStitch.DesiredStitchLevel1();
                break;
            case LevelStatus.Level2:
                desiredStitch.DesiredStitchLevel2();
                break;
            case LevelStatus.Level3:
                desiredStitch.DesiredStitchLevel3();
                break;
        }
    }

    public void LevelControlButton()
    {
        foreach (Transform child in desiredStitch.transform)
        {
            //childleri temizlr
            Destroy(child.gameObject);
        }
      
        DesiredLevelControl();
    }
}
