using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishNextButton : MonoBehaviour
{
   public static int levelDoneCount;
   public void FinishNext()
   {
      switch (LevelMeneger.levelStatus)
      {
         case LevelStatus.Level1 :
            levelDoneCount = 1;
         break;
         case LevelStatus.Level2 :
            levelDoneCount = 2;
            break;
         case LevelStatus.Level3 :
            levelDoneCount = 3;
            break;
         case LevelStatus.Level4 :
            levelDoneCount = 4;
            break;
         case LevelStatus.Level5 :
            levelDoneCount = 5;
            break;
         case LevelStatus.Level6 :
            levelDoneCount = 6;
            break;
         case LevelStatus.Level7 :
            levelDoneCount = 7;
            break;
         case LevelStatus.Level8 :
            levelDoneCount = 8;
            break;
         case LevelStatus.Level9 :
            levelDoneCount = 9;
            break;
         case LevelStatus.Level10 :
            levelDoneCount = 10;
            break;
         case LevelStatus.Level11 :
            levelDoneCount = 11;
            break;
         case LevelStatus.Level12 :
            levelDoneCount = 12;
            break;
         case LevelStatus.Level13 :
            levelDoneCount = 13;
            break;
         case LevelStatus.Level14 :
            levelDoneCount = 14;
            break;
         case LevelStatus.Level15 :
            levelDoneCount = 15;
            break;
         case LevelStatus.Level16 :
            levelDoneCount = 16;
            break;
         case LevelStatus.Level17 :
            levelDoneCount = 17;
            break;
         case LevelStatus.Level18 :
            levelDoneCount = 18;
            break;
         case LevelStatus.Level19 :
            levelDoneCount = 19;
            break;
         case LevelStatus.Level20 :
            levelDoneCount = 20;
            break;
         case LevelStatus.Level21 :
            levelDoneCount = 21;
            break;
         case LevelStatus.Level22 :
            levelDoneCount = 22;
            break;
         case LevelStatus.Level23 :
            levelDoneCount = 23;
            break;
      }
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }
}
