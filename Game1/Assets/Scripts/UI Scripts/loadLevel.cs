using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public void LoadByIndex(int sceneIndex)   //a universal loadlevel script used to load any level in the game by using sceneIndex.
    {
        SceneManager.LoadScene(sceneIndex);
        PlayerPrefs.DeleteAll();
    }
}
