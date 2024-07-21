using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void ResetButton()
    {
        PlayerPrefs.SetInt("DiamondCount", 0);
        PlayerPrefs.GetInt("DiamondCount").ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}