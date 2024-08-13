using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Unity.Collections;

public class StitchControl : Tumbnails
{
    [Header("Stitch")] [SerializeField] private GameObject parentInstantiate;
    [SerializeField] private GameObject stitch;
    [SerializeField] private GameObject needle;
    [SerializeField] private Animator needleAnim;
    [SerializeField] public float lastXPos;
    [SerializeField] public int stitchCount = 0;
    [HideInInspector] public float time;
    [HideInInspector] public bool isDown;
    [HideInInspector] public float firstNeedleX;
    [HideInInspector] public float firstNeedleY;
    [HideInInspector] public int i = 0;
    [HideInInspector] public int j = 0;
    [SerializeField] private Button stitchButton;

    [Header("Star")] [SerializeField] private StarControl starControl;

    [Header("TrueColorControl")] [SerializeField]
    private BackGround backGroundDesired;
    [SerializeField] public int trueStitchInt;
    [SerializeField] public int falseStitchInt;

    [SerializeField] private Color desiredColor;
    [SerializeField] private GameObject undoStitch;
    [SerializeField] private Image autoTimeImage;

    [HideInInspector] public GameObject stitchObject;
    [SerializeField] private GameObject falseStitchEffect;
    [SerializeField] private AudioSource failStitchSound;
    [SerializeField] private AudioSource stitchSound;

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

        StartPixelColor();
    }

    public void StartPixelColor()
    {
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

    public void DownStitch()
    {
        if (stitchButton.interactable)
        {
            if (isDown)
            {
                autoTimeImage.fillAmount += .1f;
                if (autoTimeImage.fillAmount >= .95f)
                {
                    Knit();
                }
            }
            else
            {
                //    needle anim dursun
                autoTimeImage.fillAmount = 0;
                needleAnim.SetBool("isNeedle", false);
            }
        }
    }

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
                var minColorA = color.a - 20;
                var maxColorA = color.a + 20;
                var minColorR = color.r - 20;
                var maxColorR = color.r + 20;
                var minColorG = color.g - 20;
                var maxColorG = color.g + 20;
                var minColorB = color.b - 20;
                var maxColorB = color.b + 20;


                //if (stitchColor.a == color.a && stitchColor.r == color.r && stitchColor.g == color.g &&
                //     stitchColor.b == color.b)

                if (minColorA < stitchColor.a && stitchColor.a < maxColorA &&
                    minColorR < stitchColor.r && stitchColor.r < maxColorR &&
                    minColorG < stitchColor.g && stitchColor.g < maxColorG &&
                    minColorB < stitchColor.b && stitchColor.b < maxColorB)
                {
                    trueStitchInt++;
                    obj.GetComponent<StitchState>().isTrueStitch = true;
                    obj.GetComponent<StitchState>().isFalseStitch = false;
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
                    obj.GetComponent<StitchState>().isTrueStitch = false;
                    obj.GetComponent<StitchState>().isFalseStitch = true;
                    failStitchSound.Play();
                }
            }
        }
        else
        {
            autoTimeImage.fillAmount = 0;
            Debug.DrawLine(center, rayDirection, Color.green, 1000);
        }
    }

    public void Click()
    {
        Knit();
    }

    public void Knit()
    {
        needleAnim.SetBool("isNeedle", true);
        stitchSound.Play();
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
                                woolBeforeImage.transform.GetChild(1).GetComponent<Image>().color =
                                    desiredColor;
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

                needle.transform.position += new Vector3(.155f, 0, 0);
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
                needle.transform.position += new Vector3(0, .155f, 0);

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
}