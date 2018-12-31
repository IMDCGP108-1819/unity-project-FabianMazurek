using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint : MonoBehaviour {

    public LevelManager levelManager;

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

		//when the player goes through a checkpoint trigger the currentCheckpoint is set that checkpoint, meaning that when the killplayer script is triggered the player spawns at the most recent checkpoint.
	
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.currentCheckpoint = gameObject;
        }
    }
}

