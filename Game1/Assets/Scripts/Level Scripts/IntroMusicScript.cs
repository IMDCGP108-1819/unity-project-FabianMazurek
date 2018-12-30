using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMusicScript : MonoBehaviour
{
    public GameObject IntroMusic;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        IntroMusic.SetActive(true);
    }
}
