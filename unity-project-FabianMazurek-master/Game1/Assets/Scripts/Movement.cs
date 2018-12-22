using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float m_Speed;
    public float m_Speed2;
    public float jumpHeight;
    public float velocity;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    public float Speed = 0;
    public float MaxSpeed = 10;
    public float Acceleration = 2.5f;
    public float Deceleration = 3.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
/*
        if (Input.GetKey("Left") && Speed <= MaxSpeed)
            Speed = Speed - Acceleration * Time.deltaTime;
        else if (Input.GetKey("Right") && Speed >= -MaxSpeed)
            Speed = Speed + Acceleration * Time.deltaTime;
        else
        {
            if (Speed > Deceleration * Time.deltaTime)
                Speed = Speed - Deceleration * Time.deltaTime;
            else if (Speed < -Deceleration * Time.deltaTime)
                Speed = Speed + Deceleration * Time.deltaTime;
            else
                Speed = 0;


        }
        transform.position.x = transform.position.x + Speed * Time.deltaTime;*/
    }
}