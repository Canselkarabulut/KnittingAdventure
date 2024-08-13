using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishTextControl : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lastStitchCountText;
    [SerializeField] private TextMeshProUGUI lasrStarCountText;
    [SerializeField] private TextMeshProUGUI conclusionText;
    [SerializeField] public int conclusion;
    [SerializeField] private StarControl starControl;
    [SerializeField] public bool isClick;
    [SerializeField] private AudioSource clickSound;
    private int count;
    private int lastDiamond;
    private int newDiamond;
    private float time;
    private bool isCount;

    public void Conclusion()
    {
        lastStitchCountText.text = DoneButton.lastStitchCount.ToString();
        lasrStarCountText.text = starControl.starCount.ToString();
        conclusion = DoneButton.lastStitchCount * starControl.starCount;
        lastDiamond = PlayerPrefs.GetInt("DiamondCount"); //eski elması al
        newDiamond = conclusion + lastDiamond; // iki parayıda topla
        PlayerPrefs.SetInt("DiamondCount", newDiamond); // rame gönder
        count = 0;
        isCount = true;
    }
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
            if (!isClick)
            {
                clickSound.Play();
                count = conclusion + 1;
                conclusionText.text = conclusion.ToString();
                isClick = true;
            }
        }
    }
}