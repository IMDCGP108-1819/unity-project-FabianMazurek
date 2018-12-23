﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public LevelManager levelManager;

	// Use this for initialization
	void Start ()
    {
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)   //the things that 'kill' the player are triggers, when the player touches them the RespawnPlayer function from the levelManager script is called.
    {
        if(other.name == "Player")           
        {
            levelManager.RespawnPlayer();
        }
    }
}
