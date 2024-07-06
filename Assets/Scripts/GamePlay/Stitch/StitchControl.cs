using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Unity.Collections;

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

    [Header("Star")] public StarControl starControl;
    [Header("TrueColorControl")] public BackGround backGroundDesired;
    public int trueStitchInt;
    public int falseStitchInt;

    private Color desiredColor;
    public GameObject undoStitch;

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

            woolBeforeImage.GetComponent<Colors>().color = Color.clear;
            woolBeforeImage.transform.GetChild(1).GetComponent<Image>().color = Color.clear;

            woolNowImage.GetComponent<Colors>().color = backGroundDesired.colorArrayList[0];
            woolNowImage.transform.GetChild(1).GetComponent<Image>().color = backGroundDesired.colorArrayList[0];

            woolAfterImage.GetComponent<Colors>().color = backGroundDesired.colorArrayList[1];
            woolAfterImage.transform.GetChild(1).GetComponent<Image>().color = backGroundDesired.colorArrayList[1];
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


    [HideInInspector] public GameObject stitchObject;

    public void DownStitch()
    {
        if (isDown)
        {
            needleAnim.SetBool("isNeedle", true);
            if (i < 22)
            {
                if (j < 22)
                {
                    stitchObject = Stitch(stitch, parentInstantiate, j, j + 1, i, 1 + i);

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
                            desiredColor = index >= 0 && index < backGroundDesired.colorArrayList.Count
                                ? backGroundDesired.colorArrayList[index]
                                : clearColor;
                            switch (i)
                            {
                                case 0:
                                    before2Image.color = desiredColor;
                                    break;
                                case 1:
                                    before1Image.color = desiredColor;
                                    woolBeforeImage.GetComponent<Colors>().color = desiredColor;
                                    woolBeforeImage.transform.GetChild(1).GetComponent<Image>().color = desiredColor;
                                    break;
                                case 2:
                                    nowImage.color = desiredColor;
                                    woolNowImage.GetComponent<Colors>().color = desiredColor;
                                    woolNowImage.transform.GetChild(1).GetComponent<Image>().color = desiredColor;
                                    break;
                                case 3:
                                    after1Image.color = desiredColor;
                                    woolAfterImage.GetComponent<Colors>().color = desiredColor;
                                    woolAfterImage.transform.GetChild(1).GetComponent<Image>().color = desiredColor;
                                    break;
                                case 4:
                                    after2Image.color = desiredColor;
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

                    StitchColor(stitchObject, before1Image.color); //ilmek rengi kontrolü
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

    //private GameObject stitchObject;
    public GameObject falseStitchEffect;

    public void StitchColor(GameObject obj, Color32 color)
    {
        Vector2 center = obj.GetComponent<RectTransform>().position;
        Vector2 rayDirection = new Vector2(-1, -1);
        RaycastHit2D hit = Physics2D.Raycast(center, rayDirection, 1000);
        if (hit.collider != null)
        {
            if (hit.transform.gameObject.TryGetComponent(out Image image))
            {
                Color32 stitchColor = obj.GetComponent<Image>().color;
                if (stitchColor.a == color.a && stitchColor.r == color.r && stitchColor.g == color.g &&
                    stitchColor.b == color.b)
                {
                    trueStitchInt++;
                }
                else
                {
                    falseStitchInt++;
                    Destroy(obj);
                    obj = Stitch(undoStitch, parentInstantiate, j - 1, j, i, i + 1);
                    falseStitchEffect.transform.position = new Vector3(falseStitchEffect.transform.position.x,
                        falseStitchEffect.transform.position.y, -3);
                    falseStitchEffect.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                    falseStitchEffect.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
                    falseStitchEffect.transform.GetChild(2).GetComponent<ParticleSystem>().Play();
                   
                }
            }
        }
        else
        {
            Debug.DrawLine(center, rayDirection, Color.green, 1000);
        }
    }
}