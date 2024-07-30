using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
   public AudioSource music;
   public GameObject musicStateImage;
   public bool isActive;

   private void Start()
   {
      isActive = true;
   }

   public void MusicState()
   {
      switch (isActive)
      {
         case true:
            music.volume = 0;
            musicStateImage.SetActive(true);
            isActive = false;
            
            break;
         case false:
            music.volume = 0.5f;
            musicStateImage.SetActive(false);
            isActive = true;
            break;
      }
   }
}
