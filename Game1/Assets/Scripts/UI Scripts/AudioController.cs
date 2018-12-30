using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public GameObject ukulele;
    // Start is called before the first frame update
    void Start()
    {
        ukulele.SetActive(true);
    }
    //this audiocontroller script makes sure the music plays at the start of the first level and countinues playing as the player progresses.
    
    private static AudioController instance = null;
    public static AudioController Instance
    {
        get { return instance; }
    }
    void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        if (scene.name == "MainMenu")
        {
            Destroy(this.gameObject);
            Debug.Log("I am inside the if statement");
        }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);

    }
}
    


