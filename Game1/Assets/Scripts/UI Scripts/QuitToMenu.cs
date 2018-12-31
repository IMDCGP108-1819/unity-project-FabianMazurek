using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMenu : MonoBehaviour
{
    public PauseMenu pauseMenu;
    public AudioController audioController;

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        PlayerPrefs.DeleteAll();
        pauseMenu.Resume();                //quits the game and takes the player to the menu, deletes the deaths, turns off the ukulele and turns off the pause menu.
        audioController.ukulele.SetActive(false);

    }
}