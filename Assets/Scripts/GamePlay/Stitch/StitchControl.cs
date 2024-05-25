using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StitchControl : Tumbnails
{
    [Header("Stitch")] public GameObject parentInstantiate;
    public GameObject stitch;
    public GameObject needle;
    public Animator needleAnim;
    public float lastXPos;
    public int stitchCount = 0;
    [HideInInspector] public float time;
    [HideInInspector] public bool isDown;
    [HideInInspector] public float firstNeedleX;
    [HideInInspector] public float firstNeedleY;
    [HideInInspector] public int i = 0;
    [HideInInspector] public int j = 0;
    private UndoStitchControl undoStitchControl;

    [Header("Star")] public StarControl starControl;
    [Header("TrueColorControl")] public BackGround backGroundDesired;
    public int trueStitchInt;

    public void Down() //butona basılı tutuluyor
    {
        isDown = true;
    }

    public void Up() // buton bırakılıyor
    {
        isDown = false;
    }

    private void Start()
    {
        undoStitchControl = GetComponent<UndoStitchControl>();
        stitchCount = 0;
        firstNeedleX = needle.transform.position.x;
        firstNeedleY = needle.transform.position.y;
        i = 0;
        j = 0;

        StartCoroutine(StartPixelColor());
    }

    IEnumerator StartPixelColor()
    {
        yield return new WaitForSeconds(.01f);
        if (backGroundDesired.colorArrayList.Count > 0)
        {
            before2Image.color = Color.clear;
            before1Image.color = Color.clear;
            nowImage.color = backGroundDesired.colorArrayList[0];
            after1Image.color = backGroundDesired.colorArrayList[1];
            after2Image.color = backGroundDesired.colorArrayList[2];
        }
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time >= .05f)
        {
            DownStitch();
            time = 0;
        }
    }

   // public int arrayCountNow;

    public void DownStitch()
    {
        if (isDown)
        {
            needleAnim.SetBool("isNeedle", true);
            if (i < 22)
            {
                if (j < 22)
                {
                    var stitchObject = Stitch(stitch, parentInstantiate, j, j + 1, i, 1 + i);
                    j++;
                    

                    #region Pixel Color Box
                    stitchCount++;
                    if (backGroundDesired.colorArrayList.Count > 0 && backGroundDesired.colorArrayList.Count < 485)
                    {
                        Color clearColor = Color.clear;
                        int startIndex = stitchCount - 2;

                        for (int i = 0; i < 5; i++)
                        {
                            int index = startIndex + i;
                            Color color = index >= 0 && index < backGroundDesired.colorArrayList.Count
                                ? backGroundDesired.colorArrayList[index]
                                : clearColor;
                            switch (i)
                            {
                                case 0:
                                    before2Image.color = color;
                                    break;
                                case 1:
                                    before1Image.color = color;
                                    break;
                                case 2:
                                    nowImage.color = color;
                                    break;
                                case 3:
                                    after1Image.color = color;
                                    break;
                                case 4:
                                    after2Image.color = color;
                                    break;
                            }
                        }
                    }

                    #endregion

                    #region NeedlePosition

                    needle.transform.position += new Vector3(.2f, 0, 0);
                    if (j == 21)
                    {
                        lastXPos = needle.transform.position.x;
                    }

                    #endregion
                    
                    StitchColor(stitchObject); //ilmek rengi kontrolü
                    starControl.StarActive(); // yıldız kontrolü
                }
                else
                {
                    #region NeedlePosition

                    needle.transform.position = new Vector3(firstNeedleX, needle.transform.position.y,
                        needle.transform.position.z);
                    needle.transform.position += new Vector3(0, .2f, 0);

                    #endregion
                    i++;
                    j = 0;
                }
            }
            else
            {
                //    needle anim dursun
                needleAnim.SetBool("isNeedle", false);
            }
        }
        else
        {
            //    needle anim dursun
            needleAnim.SetBool("isNeedle", false);
        }
    }


    public void StitchColor(GameObject obj)
    {
        Vector2 center = obj.GetComponent<RectTransform>().position;
        Vector2 rayDirection = new Vector2(-1, -1);
        RaycastHit2D hit = Physics2D.Raycast(center, rayDirection, 1000);
        if (hit.collider != null)
        {
            if (hit.transform.gameObject.TryGetComponent(out Image image))
            {
                //bana değen renk varsa true kısmını çalıştırıyor haliyle şimdilik doğru çalışmıyor.
                //ilmek rengi ve ray deki değen renk aynı olduğunda true olacak
                //farklı olduğunda kullanıcıyı yanlış yaptığını anlaması için bir resim vs bir şey eklenebilir
                trueStitchInt++;
                Debug.Log("true");
            }
        }
        else
        {
            // Ray hiçbir şeye çarpmadıysa
            Debug.DrawLine(center, rayDirection, Color.green, 1000);
        }
    }
}