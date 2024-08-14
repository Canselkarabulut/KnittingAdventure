using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.UI;

public class UndoStitchControl : Tumbnails
{
    [SerializeField] private GameObject needle;
    [SerializeField] private Animator needleAnim;
    [HideInInspector] public float time;
    [HideInInspector] public float firstNeedleX;
    [HideInInspector] public StitchControl stitchControl;
    [Header("Star")] [SerializeField] private StarControl starControl;
    [Header("TrueColorControl")] [SerializeField]
    private BackGround backGroundDesired;
    [SerializeField] private ParticleSystem undoButtonEffect;
    private Color32 lastColor;

    private void Start()
    {
        firstNeedleX = needle.transform.position.x;
        stitchControl = GetComponent<StitchControl>();
    }

    public void UndoStitch()
    {
        undoButtonEffect.Play();
        if (stitchControl.i > -1)
        {
            needleAnim.SetBool("isNeedle", true);
            if (stitchControl.j > 0)
            {
                stitchControl.j--;
                needle.transform.position += new Vector3(-.155f, 0, 0);
                if (transform.childCount > 0)
                {
                    var lastStitch = transform.GetChild(transform.childCount - 1).gameObject;

                    stitchControl.stitchCount--;
                    starControl.StarActive();

                    if (backGroundDesired.colorArrayList.Count > 0 && backGroundDesired.colorArrayList.Count < 485)
                    {
                        Color clearColor = Color.clear;
                        int startIndex = stitchControl.stitchCount - 2;

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
                                    woolBeforeImage.GetComponent<Colors>().color = color;
                                    woolBeforeImage.transform.GetChild(1).GetComponent<Image>().color = color;
                                    break;
                                case 2:
                                    nowImage.color = color;
                                    woolNowImage.GetComponent<Colors>().color = color;
                                    woolNowImage.transform.GetChild(1).GetComponent<Image>().color = color;
                                    break;
                                case 3:
                                    after1Image.color = color;
                                    woolAfterImage.GetComponent<Colors>().color = color;
                                    woolAfterImage.transform.GetChild(1).GetComponent<Image>().color = color;
                                    break;
                                case 4:
                                    after2Image.color = color;
                                    break;
                            }
                        }
                    }

                    StitchColor(lastStitch);
                    Destroy(lastStitch);
                }
            }
            else if (stitchControl.j == 0 && stitchControl.i > 0)
            {
                needle.transform.position = new Vector3(stitchControl.lastXPos, needle.transform.position.y,
                    needle.transform.position.z);
                needle.transform.position += new Vector3(0, -.155f, 0);
                stitchControl.j = 22;
                stitchControl.i--;
            }
        }
        else
        {
            needleAnim.SetBool("isNeedle", false);
        }
    }

    public void StitchColor(GameObject obj)
    {
        if (obj.GetComponent<StitchState>().isTrueStitch)
        {
            stitchControl.trueStitchInt--;
        }

        if (obj.GetComponent<StitchState>().isFalseStitch)
        {
            stitchControl.falseStitchInt--;
        }
    }
}