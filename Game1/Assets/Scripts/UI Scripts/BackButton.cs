using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
   public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);  //goes back to the previous menu, assigned in unity itself
    }
}
