using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)  //a script used to restart level2 when the player dies
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene("level2");
        }
    }
}
