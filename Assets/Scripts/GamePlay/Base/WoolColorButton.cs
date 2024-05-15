using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class WoolColorButton : MonoBehaviour
{
    public Image stitchPrefab;

    public void WoolColor(Color32 color)
    {
        stitchPrefab.color = color;
    }
}