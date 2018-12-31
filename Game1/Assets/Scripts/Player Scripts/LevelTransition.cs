using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public LevelManager levelManager;
    private int nextSceneToLoad;
    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;

    }

    private void OnTriggerEnter2D(Collider2D other)  //when the finish flag is touched by the player it loads the next level by using the number from build index + 1.
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
}
