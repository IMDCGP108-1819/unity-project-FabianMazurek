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
        if (doorIsOpening == true)
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
