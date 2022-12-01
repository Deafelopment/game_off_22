﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public Text counterText;
    int kills;

    void Start()
    {
        
    }

    void Update()
    {
        ShowKills();
    }

    private void ShowKills()
    {
        counterText.text = kills.ToString();
    }

    public void AddKill()
    {
        kills++;
    }

}
