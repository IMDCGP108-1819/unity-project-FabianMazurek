using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorHorizontal : MonoBehaviour
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
        if (transform.position.x > LeftPosition)
        {
            Debug.Log("going left");
            moveDirection = Vector3.left;
        }
        transform.Translate(moveDirection * Time.deltaTime * ElevatorSpeed);

        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            collision.collider.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(null);
        }
    }
}