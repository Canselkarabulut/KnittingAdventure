using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class UndoStitchControl : Tumbnails
{
  
    public GameObject needle;
    public Animator needleAnim;
    [HideInInspector] public float time;
    [HideInInspector] public float firstNeedleX;
    [HideInInspector] public StitchControl stitchControl;
   
    [Header("Star")]
    public StarControl starControl;
    [Header("TrueColorControl")]
    public BackGround backGroundDesired;
    
    private void Start()
    {
        firstNeedleX = needle.transform.position.x;
        stitchControl = GetComponent<StitchControl>();
    }
    
    public void UndoStitch()
    {
        if (stitchControl.i > -1)
        {
            needleAnim.SetBool("isNeedle", true);
            if (stitchControl.j > 0)
            {
                stitchControl.j--;
                needle.transform.position += new Vector3(-.2f, 0, 0);
                if (transform.childCount > 0)
                {
          
                    var lastStitch = transform.GetChild(transform.childCount - 1).gameObject;
                    Destroy(lastStitch);
                    stitchControl.stitchCount--;
                    starControl.StarActive();
                   
                    if (backGroundDesired.colorArrayList.Count > 0 && backGroundDesired.colorArrayList.Count < 485)
                    {
                        Color clearColor = Color.clear;
                        int startIndex = stitchControl.stitchCount - 2;

                        for (int i = 0; i < 5; i++)
                        {
                            int index = startIndex + i;
                            Color color = index >= 0 && index < backGroundDesired.colorArrayList.Count ? backGroundDesired.colorArrayList[index] : clearColor;
                            switch (i)
                            {
                                case 0:
                                    before2Image.color = color;
                                    break;
                                case 1:
                                    before1Image.color = color;
                                    break;
                                case 2:
                                    nowImage.color = color;
                                    break;
                                case 3:
                                    after1Image.color = color;
                                    break;
                                case 4:
                                    after2Image.color = color;
                                    break;
                            }
                        }
                    }
                }
            }
            else if (stitchControl.j == 0 && stitchControl.i > 0)
            {
                needle.transform.position = new Vector3(stitchControl.lastXPos, needle.transform.position.y,
                    needle.transform.position.z);
                needle.transform.position += new Vector3(0, -.2f, 0);
                stitchControl.j = 22;
                stitchControl.i--;
            }
        }
        else
        {
            needleAnim.SetBool("isNeedle", false);
        }
    }
}