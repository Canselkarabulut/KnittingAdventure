using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarControl : MonoBehaviour
{
   public StitchControl stitchControl;

   private void Update()
   {
       if (stitchControl.stitchCount >= 100)
       {
           //1. yıldızı yak
           if (stitchControl.stitchCount >= 300)
           {
               //2. yıldızı yak
               if (stitchControl.stitchCount >= 450)
               {
                   //3. yıldızı yak
               }
               else
               {
                   //3. yıldızı söndür
               }
           }
           else
           {
               //2. yıldızı söndür
           }
       }
       else
       {
           //1. yıldızı södür
       }
   }
}
