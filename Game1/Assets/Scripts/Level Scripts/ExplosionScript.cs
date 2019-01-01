using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ExplosionScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)  //when the finish flag is touched by the player it loads the next level by using the number from build index + 1.
    {
        if (other.name == "SquiggleAsteroid")
        {
            FindObjectOfType<AudioManager>().Play("ExplosionSound");
        }
    }
}
