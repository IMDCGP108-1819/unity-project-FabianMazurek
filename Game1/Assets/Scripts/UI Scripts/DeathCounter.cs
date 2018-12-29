﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCounter : MonoBehaviour
{
    public static int deathValue = 0;
    public Text deaths;

    
    void Start() //finds the text object
    {
        deaths = FindObjectOfType<Text> ();
    }
    private static DeathCounter instance = null;
    public static DeathCounter Instance
    {
        get { return instance; }
    }

    void Update()
    {
        deaths.text = "Deaths: " + deathValue;   // When the player is killed, deathValue gets updated and the text changes, the score ui doesnt get destroyed between levels.

        
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
