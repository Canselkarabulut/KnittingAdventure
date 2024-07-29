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
        isCount = true;
     //   StartCoroutine(ConclusionAnim());
    }

   // private IEnumerator ConclusionAnim()
   // {
   //     yield return new WaitForSeconds(.01f);
   //     if (count <= conclusion)
   //     {
   //         conclusionText.text = count.ToString();
   //         count++;
   //         StartCoroutine(ConclusionAnim());
   //     }
   //     else
   //     {
   //         PlayerPrefs.SetInt("DiamondCount", count - 1);
   //     }
   // }

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
                PlayerPrefs.SetInt("DiamondCount", count - 1);
            }
        }
        
    }
}