using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    [SerializeField] private GameObject soundControl;
    [SerializeField] private GameObject soundOnOffImage;
    private bool isClick = false;
    public List<GameObject> soundsList;

    private void Start()
    {
        isClick = true;
    }

    private List<GameObject> soundList;

    public void Sounds()
    {
        if (isClick)
        {
            Debug.Log("true idi");
            soundOnOffImage.SetActive(true);
            soundControl.SetActive(false);
            isClick = false;
        }
        else
        {
            Debug.Log("false idi");
            soundOnOffImage.SetActive(false);
            soundControl.SetActive(true);
            isClick = true;
        }
    }
}