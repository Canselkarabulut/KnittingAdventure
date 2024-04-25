using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrow : Tumbnails
{
    private int i = 0;
    private int j = 0;
    private float _firstNeedleX;
    private float _time;
    private bool _isDown;
    
    public GameObject parentInstantiate;
    public GameObject stitch;
    public GameObject needle;
    
    
    
    
    
    public void Down() //butona basılı tutuluyor
    {
        _isDown = true;
    }
    public void Up() // buton bırakılıyor
    {
        _isDown = false;
    }
    private void Start()
    {
        i = 0;
        j = 0;
        _firstNeedleX = needle.transform.position.x;
    }
    private void Update()
    {
        _time += Time.deltaTime;
        if (_time >= .1f)
        {
            DownStitch();
            _time = 0;
        }
    }

    public Animator needleAnim;
    public void DownStitch()
    {
        if (_isDown)
        {  
            needleAnim.SetBool("isNeedle",true);  
            if (i < 23)
            {
                if (j < 23)
                {
                    Stitch(stitch, parentInstantiate, j, j + 1, i, 1 + i);
                    j++;
                    needle.transform.position += new Vector3(.2f, 0, 0);
                }
                else
                {
                    needle.transform.position = new Vector3(_firstNeedleX,needle.transform.position.y,needle.transform.position.z);
                    needle.transform.position += new Vector3(0, .2f, 0);
                    i++;
                    j = 0;
                }
            }
            else
            {
            //    needle anim dursun
            needleAnim.SetBool("isNeedle",false);  
            }
           
        }
        else
        {
            //    needle anim dursun
            needleAnim.SetBool("isNeedle",false);  
        }
    }

  
}