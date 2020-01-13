﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSetup : MonoBehaviour
{
    public string MethodName;
    private DataHolder dataHolder;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);

        dataHolder = GameObject.Find("DataHolder").GetComponent<DataHolder>();
    }

    void OnClick()
    {
        if (MethodName == "Play")
        {
            dataHolder.Play();
        }
        else if (MethodName == "Exit")
        {
            dataHolder.Exit();
        }
        else if (MethodName == "Setup")
        {
            string name = GameObject.Find("Name").GetComponent<TextMeshProUGUI>().text;
            dataHolder.SetupPlayer(name);
        }
    }
}