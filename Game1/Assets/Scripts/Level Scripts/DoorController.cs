using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public GameObject Button;
    public bool doorIsOpening;
    public bool buttonIsPressed;
    private void Update()
    {
        if (doorIsOpening == true)                  //when the button trigger is pushed the gameobject tagged "door" is set to inactive along with the button itself.
        {
            Door.SetActive(false);
        }
        if (buttonIsPressed == true)
        {
            Button.SetActive(false);
        }
            
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        doorIsOpening = true;
        buttonIsPressed = true;
        
    }

}
