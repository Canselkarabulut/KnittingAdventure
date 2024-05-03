using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialControl : MonoBehaviour
{
    public GameObject tutorial1ShowingWoolTutorialPanel;
    public GameObject hand;
    public GameObject target1; // wool Right Target
    public GameObject target2; // wool Right Move Start Target
    public GameObject target3; // wool Left Target
    public Scrollbar scrollbar;
    public Button closeButtonShowingWoolTutorial;

    public void Tutorial1WoolColor()
    {
        tutorial1ShowingWoolTutorialPanel.SetActive(true);
    }

    private int distanceNum = 0;

    private void Update()
    {
        if (distanceNum == 0)
        {
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
                hand.transform.GetChild(1).gameObject.SetActive(true); // Sürükleme resmi açıldı  scrollba
                //scroll bar da kaysacak burada}
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
                //   hand.transform.GetChild(1).gameObject.SetActive(true); // Sürükleme resmi açıldı  scrollba
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
                //    hand.transform.GetChild(1).gameObject.SetActive(true); // Sürükleme resmi açıldı  scrollba
                hand.transform.GetChild(0).gameObject.SetActive(false);
                hand.transform.GetChild(1).gameObject.SetActive(false);
                distanceNum = 4;
            }
            else
            {
                scrollbar.value -= .8f * Time.deltaTime;
            }
        }
    }

    //renkli yün yerine tıkalndıysa ve distance num 4 ise bir sonraki tutorial açılacak
    public void WoolColorScroolButtonClick()
    {
        if (distanceNum == 4)
        {
            tutorial1ShowingWoolTutorialPanel.SetActive(false);
            hand.gameObject.SetActive(false);
            closeButtonShowingWoolTutorial.gameObject.SetActive(false);
            //2. tutorial başlayacak mini resim aktif olsun ve bizden mavi yünü seçmamiz istensin
        }
    }
}