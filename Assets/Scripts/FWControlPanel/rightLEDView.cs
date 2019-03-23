﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightLEDView : MonoBehaviour
{
    public GameObject panelUEexecuted;
    public GameObject panelBrandfallControlAb;
    public GameObject panelLEDAcoustigSignal;
    public GameObject panelBMZReset;

    private Image imageUEExecuted;
    private Image imageBrandFallControlAb;
    private Image imageLEDAcousticSignal;
    private Image imageBMZReset;


    // Start is called before the first frame update
    void Start()
    {
        imageUEExecuted = panelUEexecuted.GetComponent<Image>();
        imageBrandFallControlAb = panelBrandfallControlAb.GetComponent<Image>();
        imageLEDAcousticSignal = panelLEDAcoustigSignal.GetComponent<Image>();
        imageBMZReset = panelBMZReset.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchLEDUEExecutedOn()
    {
        imageUEExecuted.color = Color.red;

    }
    public void switchLEDUEExecutedOff()
    {
        imageUEExecuted.color = Color.grey;
    }
    public void switchLDBrandFallControlAbOn()
    {
        imageBrandFallControlAb.color = Color.yellow;
    }
    public void switchLEDBrandFallControlAbOff()
    {
        imageBrandFallControlAb.color = Color.grey;
    }

    public void switchImageMZResetOn()
    {
        imageBMZReset.color = Color.red;
    }
    public void switchBMZResetOff()
    {
        imageBMZReset.color = Color.grey;
    }

}
