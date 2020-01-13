﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{

    private string playerName;
    private Dictionary<string, float> playerProgression;

    public Player()
    {
        playerProgression = new Dictionary<string, float>();
    }

    public Player(string name)
    {
        playerName = name;
        playerProgression = new Dictionary<string, float>();
    }

    public void SetProgression(string name, float points)
    {
        playerProgression[name] = points;
    }

    public string PlayerName
    {
        set
        {
            playerName = value;
        }
        get
        {
            return playerName;
        }
    }

    public Dictionary<string, float> PlayerProgression
    {
        get
        {
            return playerProgression;
        }
    }
}