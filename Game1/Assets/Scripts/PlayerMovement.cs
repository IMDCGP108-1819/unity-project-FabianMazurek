using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
    void FixedUpdate()
    {
        //Code that checks if the player is on the ground.
        
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        
    }
    void Update()
    {
        //player movement

        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-m_Speed, GetComponent<Rigidbody2D>().velocity.y);
        }
    
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(m_Speed, GetComponent<Rigidbody2D>().velocity.y);
        }
      
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

         
            
        }
        */
        
        if (Input.GetKey(KeyCode.LeftArrow) && Speed <= MaxSpeed)
            Speed = Speed - Acceleration * Time.deltaTime;
        else if (Input.GetKey(KeyCode.RightArrow) && Speed >= -MaxSpeed)
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
        
    }
}