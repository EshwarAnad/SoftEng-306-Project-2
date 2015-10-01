﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class TestModalWindow : MonoBehaviour
{
    private DialogPanel modalPanel;
    private DisplayManager displayManager;
    public List<string> dialogText = new List<string>();

    void Awake()
    {
        modalPanel = DialogPanel.Instance();
        displayManager = DisplayManager.Instance();
    }

    //  Send to the Modal Panel to set up the Buttons and Functions to call
    public void startDialog()
    {
        StartCoroutine(modalPanel.StartDialog(dialogText)); 
    }
}