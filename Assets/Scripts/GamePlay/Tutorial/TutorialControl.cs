using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialControl : MonoBehaviour
{    private int distanceNum = 0;
    [Header("Tutorial1ShowingWool")] public GameObject tutorial1ShowingWoolTutorialPanel;
    public GameObject hand;
    public Animator handAnim;
    public GameObject target1; // wool Right Target
    public GameObject target2; // wool Right Move Start Target
    public GameObject target3; // wool Left Target
    public Scrollbar scrollbar;
    public Button closeButtonShowingWoolTutorial;
    [Header("Tutorial2SelectedWool")] public GameObject miniImage;
    public GameObject tutorial2selectedWoolTutorialPanel;
    public GameObject tutorial2hand;
    public Animator tutorial2handAnim;
    public GameObject tutorial2target1;
    public Button blueSelectedButton;

    [Header("Tutorial3StitchArrow")] public GameObject tutorial3StitchArrowPanel;
    public GameObject tutorial3hand;
    public Animator tutorial3handAnim;
    public GameObject tutorial3target1;
    public Button tutorialStitchArrowButton;
    public Button stitchButton;
    public GameObject stitchButtonOrjinalParent;
    public GameObject stitchButtonParent;

    private void Start()
    {
        distanceNum = 0;
        miniImage.SetActive(false);
        hand.SetActive(false);
        tutorial2hand.SetActive(false);
        tutorial3hand.SetActive(false);
        tutorial1ShowingWoolTutorialPanel.SetActive(false);
        tutorial3StitchArrowPanel.SetActive(false);
        tutorial2selectedWoolTutorialPanel.SetActive(false);
        tutorialStitchArrowButton.gameObject.SetActive(false);
        if (distanceNum >= 5)
        {
            miniImage.SetActive(true);
        }
    }



    private void Update()
    {
        WoolColorScroolTutorialPanel();
        SelectedWoolTutorial();
        TutorialStitchArrow();
    }

    #region Tutorial 1

    public void WoolColorScroolTutorialPanel()
    {
        if (distanceNum == 0)
        {
            tutorial1ShowingWoolTutorialPanel.SetActive(true);
            hand.SetActive(true);
            closeButtonShowingWoolTutorial.gameObject.SetActive(true);
            hand.transform.position =
                Vector3.Lerp(hand.transform.position, target1.transform.position, 3 * Time.deltaTime);
            var distanceTarget1 = Vector3.Distance(hand.transform.position, target1.transform.position);
            if (distanceTarget1 <= .1)
            {
                hand.transform.GetChild(0).gameObject.SetActive(true); // Tıklama resmi açıldı
                distanceNum = 1;
            }
        }

        if (distanceNum == 1)
        {
            hand.transform.position =
                Vector3.Lerp(hand.transform.position, target2.transform.position, 3 * Time.deltaTime);
            var distanceTarget2 = Vector3.Distance(hand.transform.position, target2.transform.position);
            if (distanceTarget2 <= .1)
            {
                hand.transform.GetChild(1).gameObject.SetActive(true);
                distanceNum = 2;
            }
        }

        if (distanceNum == 2)
        {
            hand.transform.position =
                Vector3.Lerp(hand.transform.position, target3.transform.position, 2 * Time.deltaTime);
            var distanceTarget3 = Vector3.Distance(hand.transform.position, target3.transform.position);
            if (distanceTarget3 <= .1)
            {
                distanceNum = 3;
            }
            else
            {
                scrollbar.value += .8f * Time.deltaTime;
            }
        }

        if (distanceNum == 3)
        {
            hand.transform.position =
                Vector3.Lerp(hand.transform.position, target2.transform.position, 2 * Time.deltaTime);
            var distanceTarget4 = Vector3.Distance(hand.transform.position, target2.transform.position);
            if (distanceTarget4 <= .1)
            {
                hand.transform.GetChild(0).gameObject.SetActive(false);
                hand.transform.GetChild(1).gameObject.SetActive(false);
                
                
                //el büyüyüp küçülme animasyonu çalışsın
                handAnim.SetBool("isWaitHand1",true);
                distanceNum = 4;
            }
            else
            {
                scrollbar.value -= .85f * Time.deltaTime;
            }
        }
    }

    public void WoolColorScroolButtonClick()
    {
        if (distanceNum == 4)
        {
            tutorial1ShowingWoolTutorialPanel.SetActive(false);
            hand.gameObject.SetActive(false);
            closeButtonShowingWoolTutorial.gameObject.SetActive(false);
            distanceNum = 5;
        }
    }

    #endregion


    #region Tutorial 2

    public void SelectedWoolTutorial()
    {
        if (distanceNum == 5)
        {
            tutorial2hand.SetActive(true);
            tutorial2selectedWoolTutorialPanel.SetActive(true);
            miniImage.SetActive(true);
            tutorial2hand.transform.position =
                Vector3.Lerp(tutorial2hand.transform.position, tutorial2target1.transform.position, 2 * Time.deltaTime);
            var distanceTarget5 =
                Vector3.Distance(tutorial2hand.transform.position, tutorial2target1.transform.position);
            if (distanceTarget5 <= .1)
            {
                tutorial2hand.transform.GetChild(0).gameObject.SetActive(true);
                tutorial2handAnim.SetBool("isWaitHand2",true);
                distanceNum = 6;
            }
        }
    }

    public void SelectedWoolButtonClick()
    {
        if (distanceNum == 6)
        {
            tutorial2hand.SetActive(false);
            tutorial2selectedWoolTutorialPanel.SetActive(false);
            blueSelectedButton.gameObject.SetActive(false);
            distanceNum = 7;
        }
    }

    #endregion

    #region Tutorial3

    public void TutorialStitchArrow()
    {
        if (distanceNum == 7)
        {
            tutorial3StitchArrowPanel.SetActive(true);
            tutorial3hand.SetActive(true);

            tutorial3hand.transform.position =
                Vector3.Lerp(tutorial3hand.transform.position, tutorial3target1.transform.position, 2 * Time.deltaTime);
            var distanceTarget6 =
                Vector3.Distance(tutorial3hand.transform.position, tutorial3target1.transform.position);
            if (distanceTarget6 <= .1)
            {
                tutorial3hand.transform.GetChild(0).gameObject.SetActive(true);
                tutorial3handAnim.SetBool("isWaitHand3",true);
                // tutorialStitchArrowButton.gameObject.SetActive(true);
                stitchButton.transform.SetParent(stitchButtonParent.transform);
                distanceNum = 8;
            }
        }
    }

    public void TutorialStitchArrowButton()
    {
        if (distanceNum == 8)
        {
            tutorial3StitchArrowPanel.SetActive(false);
            tutorial3hand.SetActive(false);
            stitchButton.transform.SetParent(stitchButtonOrjinalParent.transform);
            distanceNum = 9;
        }
    }

    #endregion
}