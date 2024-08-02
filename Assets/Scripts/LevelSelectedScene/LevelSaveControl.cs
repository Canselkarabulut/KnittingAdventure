using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSaveControl : MonoBehaviour
{
   public List<int> levelListCount;
   public List<int> listStarCount;
   private const int ListSize = 23;
   private int[] arraylevelListCount = new int[ListSize];
   private const string ListKey = "MyList";
   
   private void Start()
   {
      LoadList();
     
   }

   public void LevelSave(DoneButton doneButton,StarControl starControl)
   {
      levelListCount[doneButton.levelDoneCount] = doneButton.levelDoneCount;//bulunduğumuz level sayısı listeye eklendi;
      listStarCount[doneButton.levelDoneCount] = starControl.starCount;

      SaveList(arraylevelListCount);


   } 
   

   
   private void SaveList(int[] list)
   {
      for (int i = 0; i < list.Length; i++)
      {
         PlayerPrefs.SetInt(ListKey + i, list[i]);
      }
      PlayerPrefs.Save();
   }
   private int[] LoadList()
   {
      int[] list = new int[ListSize];
      for (int i = 0; i < ListSize; i++)
      {
         list[i] = PlayerPrefs.GetInt(ListKey + i, 0);
      }
      return list;
   }
}
