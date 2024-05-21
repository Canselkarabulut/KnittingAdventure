using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class BackGround : Tumbnails
{
    public GameObject imagePrefabInstantiate;
    public GameObject parentInstantiate;

   // public Image desiredImage;
   // public List<Sprite> sprites;
   public List<Texture2D> levelTexture2d;
public void DesiredStitchLevel1()
    {
       Stitch(imagePrefabInstantiate, parentInstantiate,0,22,0,22,levelTexture2d[0]);
    }
    public void DesiredStitchLevel2()
    {
        Stitch(imagePrefabInstantiate, parentInstantiate,0,22,0,22,levelTexture2d[1]);
    }

    public void DesiredStitchLevel3()
    {
        Stitch(imagePrefabInstantiate, parentInstantiate,0,22,0,22,levelTexture2d[2]);
    }
}