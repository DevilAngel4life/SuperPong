using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    private Rigidbody2D mov;


    void BouncyBall()                       // random first lauch at the begging of the game
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            mov.AddForce(new Vector2(20, -15));

        }
        else mov.AddForce(new Vector2(-20, 15));
    }
	// Use this for initialization

     void ResetBall()                   // Resets the Ball position upon  players wall hit or restart buttom
    {
        mov.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()                  // Restart the game
    {
        ResetBall();
        Invoke("BouncyBall", 1);
    }

    void OnCollisionEnter2D(Collision2D collision)      // allows for the collision on the paddles
    {
            if (collision.collider.CompareTag("Player"))
        {
            Vector2 speed;
            speed.x = mov.velocity.x;
            speed.y = (mov.velocity.y / 2) + (collision.collider.attachedRigidbody.velocity.y / 3);
            
            mov.velocity = speed;
        }
    }

    void Start () {                         // Begging the game with the start of the Ball
        mov = GetComponent<Rigidbody2D>();
        Invoke("BouncyBall", 2);
	}
	
}
