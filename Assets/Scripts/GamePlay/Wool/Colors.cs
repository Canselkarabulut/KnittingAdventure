using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Colors : MonoBehaviour
{
    public Image stitchPrefab;
    public Color32 color = new Color(1, 0.9686275f, 0, 1);
   
    public void ColorsButton()
    {
        stitchPrefab.color = color;
        transform.GetChild(2).transform.GetChild(0).GetComponent<ParticleSystem>().Play();
    }
}