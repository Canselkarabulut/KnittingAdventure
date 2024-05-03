using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BackGround : Tumbnails
{
    public GameObject imagePrefabInstantiate;
    public GameObject parentInstantiate;
    public Color stitchColor;
    public void DesiredStitchLevel1()
    {
        Stitch(imagePrefabInstantiate, parentInstantiate,0,22,0,22,stitchColor);
    }
    public void DesiredStitchLevel2()
    {
        Stitch(imagePrefabInstantiate, parentInstantiate,0,22,0,1,Color.green);
        Stitch(imagePrefabInstantiate, parentInstantiate,0,22,1,3,Color.red);
        Stitch(imagePrefabInstantiate, parentInstantiate,0,22,3,5,Color.white);
        Stitch(imagePrefabInstantiate, parentInstantiate,0,22,5,22,Color.yellow);
    }
}