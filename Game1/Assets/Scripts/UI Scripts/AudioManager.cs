using UnityEngine.Audio;
using UnityEngine;
using System;
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;
    
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;                         //makes sure there is only one instance of audiomanger per scene since its set to DontDestroyOnLoad.
        }
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);      //this function finds the soundclip and plays it if Play("song"); is called
        s.source.Play();
    }

    public void Pause(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Pause();
    }
void Start()
    {
        
        Play("IntroMusic");
    }

}
// used Brackeys video "introduction to audio" after struggling for days with getting this stuff to work