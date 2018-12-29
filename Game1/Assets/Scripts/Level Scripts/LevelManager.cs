using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;
    public GameObject trampoline;
    private PlayerMovement player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerMovement>();  //establishes what the player is
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = currentCheckpoint.transform.position;  //when this fucntion is called it teleports the player to the currentCheckpoint's location.
        
    }
}
