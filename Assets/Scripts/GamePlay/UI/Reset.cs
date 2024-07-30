using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject entryScene;
    public GameObject levelScene;
    public GameObject gameScene;
    public GameObject gaemFinishScene;
    public void ResetButton()
    {
        PlayerPrefs.SetInt("DiamondCount", 0);
        PlayerPrefs.SetInt("LevelDoneCount",0);
        PlayerPrefs.SetInt("lastStarCount",0);   
        PlayerPrefs.SetInt("dlc",0);
        PlayerPrefs.SetInt("sc",0);
     //   PlayerPrefs.GetInt("DiamondCount").ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
            entryScene.SetActive(true);
            levelScene.SetActive(false);
            gameScene.SetActive(false);
            gaemFinishScene.SetActive(false);
        
    }
}