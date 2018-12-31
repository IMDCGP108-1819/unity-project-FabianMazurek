using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    public PauseMenu pauseMenu;
    public AudioManager audioManager;

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);  //same button layout as QuitToMenu, however it turns the ukulele back on for maximum enjoyment.
        PlayerPrefs.DeleteAll();
        pauseMenu.Resume();
        audioManager.Play("RoyaltyFreeUkulele");
        audioManager.Pause("IntroMusic");
        
    }
}
