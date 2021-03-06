﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.right;
    public float RightPosition;
    public float LeftPosition;
    public float ElevatorSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= RightPosition)
        {
            Debug.Log("going right");
            moveDirection = Vector3.right;
        }
        if (transform.position.x > LeftPosition)           //just the ElevatorHorizontal script used in a different way
        {
            Debug.Log("going left");
            moveDirection = Vector3.left;
        }
        transform.Translate(moveDirection * Time.deltaTime * ElevatorSpeed);



    }
}
