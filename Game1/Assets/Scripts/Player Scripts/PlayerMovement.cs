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
    
   
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        //Code that checks if the player is on the ground.
        
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);   //determines whether the player is touching a platform using a radius around the player
        
    }
    void Update()
    {
        //player movement

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-m_Speed, GetComponent<Rigidbody2D>().velocity.y);           //moves the player left and right
        }
    
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(m_Speed, GetComponent<Rigidbody2D>().velocity.y);
        }
      
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);   //allows the player to jump once and to a certain height as long as they are grounded
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

         
            
        }
      
    }
}