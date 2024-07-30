using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{    public StitchControl stitchControl;
    public GameObject needle;
    public Button star1;
    public Button star2;
    public Button star3;
    public GameObject gameScene;
    public GameObject levelScene;
    public FinishTextControl finishTextControl;
    public FinishStarControl finishStarControl;
    public GameObject settingPanel;
    public Settings settings;
  
    public void Back()
    {
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        foreach (Transform child in stitchControl.transform)
        {
            //childleri temizlr
            Destroy(child.gameObject);
        }
        stitchControl.i = 0;
        stitchControl.j = 0;
        stitchControl.trueStitchInt = 0;
        needle.transform.position = new Vector3(stitchControl.firstNeedleX, stitchControl.firstNeedleY,
            needle.transform.position.z);
        star1.interactable = false;
        star2.interactable = false;
        star3.interactable = false;
        gameScene.SetActive(false);
        levelScene.SetActive(true);
        settings.CloseSettingPanel();
        finishTextControl.Conclusion();
        finishStarControl.StarActiveWait();
        settingPanel.SetActive(false);

    }
}
