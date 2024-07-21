using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public LevelMeneger levelMeneger;

    public StitchControl stitchControl;
    public GameObject needle;
    public Button star1;
    public Button star2;
    public Button star3;

    public void NextBtn()
    {
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        foreach (Transform child in stitchControl.transform)
        {
            //childleri temizlr
            Destroy(child.gameObject);
        }

        stitchControl.i = 0;
        stitchControl.j = 0;
        stitchControl.trueStitchInt = 0;
        needle.transform.position = new Vector3(stitchControl.firstNeedleX, stitchControl.firstNeedleY,
            needle.transform.position.z);
        star1.interactable = false;
        star2.interactable = false;
        star3.interactable = false;

        switch (LevelMeneger.levelStatus)
        {
            case LevelStatus.Level1:
                LevelMeneger.levelStatus = LevelStatus.Level2;
                break;
            case LevelStatus.Level2:
                LevelMeneger.levelStatus = LevelStatus.Level3;
                break;
        }
        gameObject.SetActive(false);
    }
}