﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Message
{
    [JsonProperty]
    private string text;
    [JsonProperty]
    private bool player;
    [JsonProperty]
    private bool branching;
    [JsonProperty]
    private Dictionary<string, int> branches;

    private Animation anim;

    public Message(string text, bool player)
    {
        this.text = text;
        this.player = player;
        this.branching = false;
        branches = new Dictionary<string, int>();
    }

    public void AddOption(string buttonText, int index)
    {
        branching = true;
        branches.Add(buttonText, index);
    }

    [JsonIgnore]
    public string Text
    {
        get
        {
            return text;
        }
    }
    [JsonIgnore]
    public bool Player
    {
        get
        {
            return player;
        }
    }
    [JsonIgnore]
    public bool Branching
    {
        get
        {
            return branching;
        }
    }
    [JsonIgnore]
    public Dictionary<string,int> Branches
    {
        get
        {
            return branches;
        }
    }
}