using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;
    public GameObject trampoline;
    private PlayerMovement player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerMovement>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = currentCheckpoint.transform.position;
        
    }
}
