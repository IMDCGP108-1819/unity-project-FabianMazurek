using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class KillPlayer : MonoBehaviour {

    public LevelManager levelManager;
    public int deaths = 0;
    
    
	void Start ()
    {
        levelManager = FindObjectOfType<LevelManager>(); //finds levelManager script  
	}
	
    private void OnTriggerEnter2D(Collider2D other)   /*the things that 'kill' the player are triggers, when the player touches them 
                                                        the RespawnPlayer function from the levelManager script is called. Additionally
                                                        1 death is added to the death counter*/
    {
        if(other.name == "Player")           
        {
            PlayerPrefs.SetInt("Deaths", PlayerPrefs.GetInt("Deaths") + 1);
            levelManager.RespawnPlayer();

            FindObjectOfType<AudioManager>().Play("PlayerDeath");
        }
    }
}
