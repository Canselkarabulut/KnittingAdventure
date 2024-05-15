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
    public Color stitchColor;
   // public Image desiredImage;
   // public List<Sprite> sprites;
   public List<Texture2D> levelTexture2d;
public void DesiredStitchLevel1()
    {
    //    desiredImage.sprite = sprites[0];
       Stitch(imagePrefabInstantiate, parentInstantiate,0,22,0,22,levelTexture2d[0]);
        

    }
    public void DesiredStitchLevel2()
    {
       // Stitch(imagePrefabInstantiate, parentInstantiate,0,22,0,1,Color.green);
       // Stitch(imagePrefabInstantiate, parentInstantiate,0,22,1,3,Color.red);
       // Stitch(imagePrefabInstantiate, parentInstantiate,0,22,3,5,Color.white);
       // Stitch(imagePrefabInstantiate, parentInstantiate,0,22,5,22,Color.yellow);
    }
}