using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishNextButton : MonoBehaviour
{
   public GameObject gameFnishScene;
   public GameObject levelScene;
   public static int levelDoneCount;
   public LevelMeneger levelMeneger;
   public LevelTextControl levelTextControl;
   public List<LevelSelect> listLevelSelect;
   public void FinishNext()
   {
      levelDoneCount = (int)levelMeneger.levelStatus+1;
      gameFnishScene.SetActive(false);
      levelScene.SetActive(true);
      levelTextControl.DiamondCountUpdate();
      PlayerPrefs.SetInt("LevelDoneCount",levelDoneCount);
      listLevelSelect[levelDoneCount-1].LevelVisitControl();
   }
}
