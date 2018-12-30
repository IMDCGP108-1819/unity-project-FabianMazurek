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
        pauseMenu.Resume();
        audioController.ukulele.SetActive(false);

    }
}