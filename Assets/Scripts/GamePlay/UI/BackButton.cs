using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    [SerializeField] private StitchControl stitchControl;
    [SerializeField] private GameObject needle;
    [SerializeField] private Button star1;
    [SerializeField] private Button star2;
    [SerializeField] private Button star3;
    [SerializeField] private GameObject gameScene;
    [SerializeField] private GameObject levelScene;
    [SerializeField] private FinishTextControl finishTextControl;
    [SerializeField] private FinishStarControl finishStarControl;
    [SerializeField] private GameObject settingPanel;
    [SerializeField] private Settings settings;

    public void Back()
    {
        foreach (Transform child in stitchControl.transform)
        {
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