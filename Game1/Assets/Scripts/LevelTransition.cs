using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public LevelManager levelManager;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)  //when the finish flag is touched by the player it loads the next level
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
