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
    public Image miniImage;
    
    public List<Color> colorArrayList;
    public List<Texture2D> levelTexture2d;
    public List<Texture2D> miniImageLevel;

    public void DesiredStitchLevel(int textureIndex)
    {
        Stitch(imagePrefabInstantiate, parentInstantiate, 0, 22, 0, 22, levelTexture2d[textureIndex], colorArrayList);
        miniImage.sprite = miniImage.sprite = Sprite.Create(miniImageLevel[textureIndex], new Rect(0, 0, miniImageLevel[textureIndex].width, miniImageLevel[textureIndex].height), Vector2.zero);;
    }
}