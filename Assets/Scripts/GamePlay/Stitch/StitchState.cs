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
    //  private void Start()
  //  {
  //      isTrueStitch = false;
  //      isFalseStitch = false;
  //  }

  //  public void TrueStitchStateTrue()
  //  {
  //      isTrueStitch = true;
  //  }
  //  public void FalseStitchStateTrue()
  //  {
  //       isFalseStitch = true;
  //  }
}
