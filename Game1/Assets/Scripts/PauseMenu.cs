using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;
    
    
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape)) // if escape is pressed and the game isnt paused the it pauses the game, else it resumes
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        AudioListener.pause = false;
    }
    void Pause()            //when the game is paused, the pauseMenuUI is set to true, time and music are paused.
    {
        pauseMenuUI.SetActive(true);          
        optionsMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        AudioListener.pause = true;
    }
   

}

