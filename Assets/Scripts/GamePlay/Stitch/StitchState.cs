using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StitchState : MonoBehaviour
{
    [SerializeField] public bool isTrueStitch;
    [SerializeField] public bool isFalseStitch;

    private void Awake()
    {
        isTrueStitch = false;
        isFalseStitch = false;
    }
}
