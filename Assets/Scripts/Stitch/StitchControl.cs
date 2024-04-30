using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StitchControl : Tumbnails
{
    public GameObject parentInstantiate;
    public GameObject stitch;
    public GameObject needle;
    public Animator needleAnim;
    [HideInInspector] public float time;
    [HideInInspector] public bool isDown;
    [HideInInspector] public float firstNeedleX;
    [HideInInspector] public int i = 0;
    [HideInInspector] public int j = 0;
    [HideInInspector] private UndoStitchControl undoStitchControl;
    public float lastXPos;
    public void Down() //butona basılı tutuluyor
    {
        isDown = true;
    }

    public void Up() // buton bırakılıyor
    {
        isDown = false;
    }

    private void Start()
    {
        undoStitchControl = GetComponent<UndoStitchControl>();
        firstNeedleX = needle.transform.position.x;
        i = 0;
        j = 0;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time >= .05f)
        {
            DownStitch();
            time = 0;
        }
    }

    public int stitchCount;
    public void DownStitch()
    {
   
        if (isDown)
        {
            needleAnim.SetBool("isNeedle", true);
            undoStitchControl.lastStitchObject =0;
            if (i < 22)
            {
                if (j < 22)
                {
                    Stitch(stitch, parentInstantiate, j, j + 1, i, 1 + i);
                    j++;
                    needle.transform.position += new Vector3(.2f, 0, 0);
                    if (j == 21)
                    {
                         lastXPos = needle.transform.position.x;
                    }

                    stitchCount++;
                    Debug.Log(stitchCount);
                }
                else
                {
                    needle.transform.position = new Vector3(firstNeedleX, needle.transform.position.y,
                        needle.transform.position.z);
                    needle.transform.position += new Vector3(0, .2f, 0);
                    i++;
                    j = 0;
                }
            }
            else
            {
                //    needle anim dursun
                needleAnim.SetBool("isNeedle", false);
            }
        }
        else
        {
            //    needle anim dursun
            needleAnim.SetBool("isNeedle", false);
        }
    }
}