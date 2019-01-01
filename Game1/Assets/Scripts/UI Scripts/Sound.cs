using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;         //desire name of sound clip

    public AudioClip clip;      

    [Range(0f, 1f)]             //volume and pitch sliders along with a loop bool
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}

// used Brackeys video "introduction to audio" after struggling for days with getting this stuff to work