using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class UndoStitchControl : Tumbnails
{
    public GameObject parentInstantiate;
    public GameObject undoStitch;
    public GameObject needle;
    public Animator needleAnim;
    [HideInInspector] public float time;
    [HideInInspector] public float firstNeedleX;
    [HideInInspector] public StitchControl stitchControl;

    private void Start()
    {
        firstNeedleX = needle.transform.position.x;
        stitchControl = GetComponent<StitchControl>();
    }

    private Vector3 lastneedletransform;
    public int lastStitchObject;
    public StarControl starControl;

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
                    lastStitchObject++;
                   
              //      transform.GetChild(transform.childCount - lastStitchObject).gameObject.SetActive(false);
                     var a = transform.GetChild(transform.childCount - 1).gameObject;
                     Destroy(a);
                    
                    
                    stitchControl.stitchCount--;
                    starControl.StarActive();
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