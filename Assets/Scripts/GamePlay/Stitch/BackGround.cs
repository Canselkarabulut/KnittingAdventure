using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class BackGround : Tumbnails
{
    [SerializeField] private GameObject imagePrefabInstantiate;
    [SerializeField] private GameObject parentInstantiate;
    [SerializeField] private Image miniImage;
    [SerializeField] private TextMeshProUGUI levelNameText;
    [SerializeField] public List<Color> colorArrayList;
    [SerializeField] private List<Texture2D> levelTexture2d;
    [SerializeField] private List<Texture2D> miniImageLevel;
    public void DesiredStitchLevel(int textureIndex)
    {
        if (levelTexture2d.Count > 0)
        {
            Stitch(imagePrefabInstantiate, parentInstantiate, 0, 22, 0, 22, levelTexture2d[textureIndex],
                colorArrayList);

            miniImage.sprite = Sprite.Create(miniImageLevel[textureIndex],
                new Rect(0, 0, miniImageLevel[textureIndex].width, miniImageLevel[textureIndex].height), Vector2.zero);
            levelNameText.text = "Level " + (textureIndex + 1);
        }
    }
}