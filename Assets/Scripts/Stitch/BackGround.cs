using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BackGround : Tumbnails
{
    public GameObject imagePrefabInstantiate;
    public GameObject parentInstantiate;

    private void Start()
    {
        Stitch(imagePrefabInstantiate, parentInstantiate,0,22,0,22);
    }
   
}