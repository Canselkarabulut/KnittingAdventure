using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class StitchControl : Tumbnails
{
    public GameObject parentInstantiate;
    public GameObject stitch;
    public GameObject needle;
    public Animator needleAnim;
    [HideInInspector] public float time;
    [HideInInspector] public bool isDown;
    [HideInInspector] public float firstNeedleX;
    [HideInInspector] public float firstNeedleY;
    [HideInInspector] public int i = 0;
    [HideInInspector] public int j = 0;
    [HideInInspector] private UndoStitchControl undoStitchControl;
    public float lastXPos;
    public int stitchCount = 0;
    public StarControl starControl;

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
        if (isDown)
        {
            needleAnim.SetBool("isNeedle", true);
            undoStitchControl.lastStitchObject = 0;
            if (i < 22)
            {
                if (j < 22)
                {
                   var stitchObject = Stitch(stitch, parentInstantiate, j, j + 1, i, 1 + i);
                    j++;

                    needle.transform.position += new Vector3(.2f, 0, 0);
                    if (j == 21)
                    {
                        lastXPos = needle.transform.position.x;
                    }

                    StitchColor(stitchObject);
                    stitchCount++;

                    starControl.StarActive();
                }
                else
                {
                    needle.transform.position = new Vector3(firstNeedleX, needle.transform.position.y,
                        needle.transform.position.z);
                    needle.transform.position += new Vector3(0, .2f, 0);
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


    public int trueStitchInt;
    public int falseStitchInt;
    public GameObject desired;


    private Color desiredStitchColor;
    private Color stitchColor;


    public Color minDesiredStitchColor;
    public Color maxDesiredStitchColor;
    public Camera mainCamera; // Kamera referansı
    //stitch renk kontrolleri
    
    public LayerMask canvasLayer; 
    public void StitchColor(GameObject obj)
    {
        Vector2 center = obj.GetComponent<RectTransform>().position;
        Vector2 rayDirection = new Vector2(-1, -1);
        // Back yönünde bir ray oluştur
        RaycastHit2D hit =  Physics2D.Raycast(center, rayDirection,1000);
        if (hit.collider != null)
        {
            // Ray bir şeye çarptıysa
            Debug.Log("Ray bir şeye çarptı: " + hit.collider.gameObject.name);


            Color32 hitColor;
            if (hit.transform.gameObject.TryGetComponent(out Image image))
            {
                
               hitColor = image.color;
                Debug.Log("color : " + hitColor);
                trueStitchInt++;
            }
        }
        else
        {
            // Ray hiçbir şeye çarpmadıysa
            Debug.Log("Ray hiçbir şeye çarpmadı.");
            Debug.DrawLine(center, rayDirection, Color.green,1000);
        }
        
        
        
     //   Vector3 center = obj.GetComponent<RectTransform>().position;
//
     //   // Back yönünde bir ray oluştur
     //   RaycastHit hit;
     //   if (Physics.Raycast(center, -mainCamera.transform.forward, out hit,1000))
     //   {
     //       // Ray bir şeye çarptıysa
     //       Debug.Log("Ray bir şeye çarptı: " + hit.collider.gameObject.name);
     //       Debug.DrawRay(center, -mainCamera.transform.forward, Color.red,1000);
//
     //   }
     //   else
     //   {
     //       // Ray hiçbir şeye çarpmadıysa
     //       Debug.Log("Ray hiçbir şeye çarpmadı.");
     //       Debug.DrawRay(center, -mainCamera.transform.forward, Color.green,1000);
     //   }
        
        
        
        // oluşturulan ilmek ortasından bir ray atılsın ve arkasındaki renk istenilen renk ise doğru olsun
        
        
        
   //     stitchColor = transform.GetChild(stitchCount).GetComponent<Image>().color;
   //     desiredStitchColor = desired.transform.GetChild(stitchCount).GetComponent<Image>().color;
//
//
   //     minDesiredStitchColor.r = desiredStitchColor.r - .2f;
   //     minDesiredStitchColor.g = desiredStitchColor.g - .2f;
   //     minDesiredStitchColor.b = desiredStitchColor.b - .2f;
//
   //     maxDesiredStitchColor.r = desiredStitchColor.r + .2f;
   //     maxDesiredStitchColor.g = desiredStitchColor.g + .2f;
   //     maxDesiredStitchColor.b = desiredStitchColor.b + .2f;
//
   //     if (maxDesiredStitchColor.r > stitchColor.r && stitchColor.r > minDesiredStitchColor.r &&
   //         maxDesiredStitchColor.g > stitchColor.g && stitchColor.g > minDesiredStitchColor.g &&
   //         maxDesiredStitchColor.b > stitchColor.b && stitchColor.b > minDesiredStitchColor.b)
   //     {
   //         trueStitchInt++;
   //     }
   //     else
   //     {
   //           falseStitchInt++;
   //         
   //     }
        
    }
}