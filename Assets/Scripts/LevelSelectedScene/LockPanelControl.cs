using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPanelControl : MonoBehaviour
{
   [SerializeField] private GameObject doneImage;
   private void Start()
   {
      LockPanelActive();
   }
   public void LockPanelActive()
   {
      if (doneImage.activeInHierarchy)
      {
         gameObject.SetActive(false);
      }
   }
}
