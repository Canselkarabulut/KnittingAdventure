using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //ilmek sayısı 480 olduğunda bir  sonraki sahneye geçme buttonu açılacak
    public Button nextButton;
    public StitchControl stitchControl;

    private void Start()
    {
        nextButton.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (stitchControl.stitchCount >= 480 && stitchControl.trueStitchInt>=475)
        {
            nextButton.gameObject.SetActive(true);
        }
    }
}