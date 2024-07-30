using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishTextControl : MonoBehaviour
{
    public TextMeshProUGUI lastStitchCountText;
    public TextMeshProUGUI lasrStarCountText;
    public TextMeshProUGUI conclusionText;
    private int conclusion;
    private int count;
    private int lastDiamond;
    private int newDiamond;

    public void Conclusion()
    {
        lastStitchCountText.text = DoneButton.lastStitchCount.ToString();
        lasrStarCountText.text = DoneButton.lastStarCount.ToString();
        conclusion = DoneButton.lastStitchCount * DoneButton.lastStarCount;
        lastDiamond = PlayerPrefs.GetInt("DiamondCount"); //eski elması al
        newDiamond = conclusion + lastDiamond; // iki parayıda topla
        PlayerPrefs.SetInt("DiamondCount", newDiamond); // rame gönder

        count = 0;
        isCount = true;
    }


    private float time;
    private bool isCount;

    private void FixedUpdate()
    {
        if (isCount)
        {
            time += Time.deltaTime;
            if (count <= conclusion)
            {
                conclusionText.text = count.ToString();
                count++;
            }
            else
            {
                isCount = false;
                time = 0;
            }
        }

        if (Input.GetMouseButton(0))
        {
            count = conclusion + 1;
            conclusionText.text = conclusion.ToString();
        }
    }
}