using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StitchState : MonoBehaviour
{
    public bool isTrueStitch;
    public bool isFalseStitch;

    private void Awake()
    {
        isTrueStitch = false;
        isFalseStitch = false;
    }
}
