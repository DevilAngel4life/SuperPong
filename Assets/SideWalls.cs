using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SideWalls : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D BallHitInfo)      // Check to see if the ball hit the sidewall on either of the players side to Record their Score 
    {
        if (BallHitInfo.name == "Ball")
        {
            string scoreSideName = transform.name;
            GameManager.Score(scoreSideName);
            BallHitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }

}
