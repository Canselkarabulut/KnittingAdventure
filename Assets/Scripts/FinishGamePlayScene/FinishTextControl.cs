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

    public void Conclusion()
    {
        lastStitchCountText.text = DoneButton.lastStitchCount.ToString();
        lasrStarCountText.text = DoneButton.lastStarCount.ToString();
        conclusion = DoneButton.lastStitchCount * DoneButton.lastStarCount;
        count = 0;
        StartCoroutine(ConclusionAnim());
    }
    private IEnumerator ConclusionAnim()
    {
        yield return new WaitForSeconds(.01f);
        if (count <= conclusion)
        {
            conclusionText.text = count.ToString();
            count++;
            StartCoroutine(ConclusionAnim());
 
        }
        else
        {
            PlayerPrefs.SetInt("DiamondCount", count-1);
          
        }
    }
}