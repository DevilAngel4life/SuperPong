using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public KeyCode moveU = KeyCode.W;   // Allow the public to edit the input key from the unity
    public KeyCode moveD = KeyCode.S;   
    public float speed = 9.0f;          // Allow the public to edit the Speed of the paddle from the unity Default at 9.0f
    public float boundY = 2.25f;        // The max for y coordinates for the paddles
    private Rigidbody2D Obj;


    // Use this for initialization
    void Start()
    {
        Obj = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        var vel = Obj.velocity;
        if (Input.GetKey(moveU))        // Moves the Paddle depending on the imput of the Keys being  press 
        {
            vel.y = speed;

        }
        else if (Input.GetKey(moveD))
        {
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        Obj.velocity = vel;
        
        var pos = transform.position;   
        if (pos.y > boundY)             //Restric the max positions of the y coordinates/Boundries
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
         transform.position= pos;       // Sets it to the screen 
    }
}
