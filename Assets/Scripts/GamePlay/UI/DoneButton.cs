using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoneButton : MonoBehaviour
{
    public StitchControl stitchControl;
    public GameObject needle;
    public Button star1;
    public Button star2;
    public Button star3;
    public StarControl starControl;
    public static int lastStarCount;
    public static int lastStitchCount;
    public void Done()
    {
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        foreach (Transform child in stitchControl.transform)
        {
            //childleri temizlr
            Destroy(child.gameObject);
        }

        lastStarCount = starControl.starCount;
        lastStitchCount = stitchControl.trueStitchInt;
        stitchControl.i = 0;
        stitchControl.j = 0;
        stitchControl.trueStitchInt = 0;
        needle.transform.position = new Vector3(stitchControl.firstNeedleX, stitchControl.firstNeedleY,
            needle.transform.position.z);
        star1.interactable = false;
        star2.interactable = false;
        star3.interactable = false;
        gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}