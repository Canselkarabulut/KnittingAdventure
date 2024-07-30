using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour
{
    public GameObject entryScene;
    public GameObject levelScene;

    public void PlayBtn()
    {
        entryScene.SetActive(false);
       levelScene.SetActive(true);
    }
}
