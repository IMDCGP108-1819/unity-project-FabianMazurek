using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;  //Pauses all audio in the scene
    }
}
