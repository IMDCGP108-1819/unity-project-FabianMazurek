using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
     public Vector3 moveDirection = Vector3.up;
    public float TopPosition;
    public float BottomPosition;
    public float ElevatorSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y >= TopPosition)
        {
            Debug.Log("going down");
            moveDirection = Vector3.down;
        }
        if (transform.position.y < BottomPosition)                  //causes the elevator to move between topPosition and bottomPosition at a constant speed
        {
            Debug.Log("going up");
            moveDirection = Vector3.up;
        }
        transform.Translate(moveDirection * Time.deltaTime * ElevatorSpeed);

	}
}
