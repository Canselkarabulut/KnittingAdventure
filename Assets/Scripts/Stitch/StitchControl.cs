using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StitchControl : Tumbnails
{
    public GameObject imagePrefabInstantiate;
    public GameObject imagePrefabInstantiate1;
    public GameObject imagePrefabInstantiate2;
    public GameObject parentInstantiate;
    public GameObject stitch;

    void Start()
    {
        // Stitch(imagePrefabInstantiate, parentInstantiate, 23, 1);
        i = 0;
    }

    private int i;
    int a = 1;
    int b = 11;
    int c = 12;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i != 0)
            {
                if (i % 2 == 0)
                {
                    Stitch(imagePrefabInstantiate, parentInstantiate, 0, 23, i, 1 + i);
                }
                else
                {
                    Stitch(imagePrefabInstantiate1, parentInstantiate, 0, 23, i, 1 + i);
                }
            }
            else
            {
                Stitch(imagePrefabInstantiate2, parentInstantiate, 0, 23, i, 1 + i);
            }

            i++;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (i < 23)
            {
                Stitch(stitch, parentInstantiate, 0, 23, i, 1 + i);
                i++;
            }
        }
    }
}