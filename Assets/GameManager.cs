using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string MenuGameScene;
    public static int one = 0;
    public static int two = 0;

    public GUISkin layout;

    GameObject ObjBall;

    // Use this for initialization
    void Start()
    {
        ObjBall = GameObject.FindGameObjectWithTag("Ball");

    }

    public static void Score(string walls)          // Keeps Track of which Player Scored
    {
        if (walls == "RightWall")
        {
            one++;
        }
        else
        {
            two++;
        }
    }

    private void OnGUI()                            // An overlay HUD that shows buttoms and information
    {
        GUI.skin = layout;                          // Displays the Players Scores 
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + one);   
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + two);

        if (GUI.Button(new Rect(Screen.width / 3 - 190, 10, 60, 20), "Main"))       // Buttom that  allow the player to return to the main menu
        {
            SceneManager.LoadScene(MenuGameScene);
        }
        
        if (GUI.Button(new Rect(Screen.width / 2 - 60, 20, 120, 37), "RESTART"))    // Buttom that reset the Game
        {
            one = 0;
            two = 0;
            ObjBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
        }

        if (one == 5)
        {
            GUI.Label(new Rect(Screen.width / 2 - 120, 80, 2000, 1500), "GAME OVER!!!");    // Information  displayed for the player one if he wins 
            GUI.Label(new Rect(Screen.width / 2 - 150, 180, 2000, 1000), "PLAYER ONE WINS");
            ObjBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        else if (two == 5)
        {
            GUI.Label(new Rect(Screen.width / 2 - 120, 80, 2000, 1500), "GAME OVER!!!");    // Information  displayed for the player two if he wins
            GUI.Label(new Rect(Screen.width / 2 - 150, 180, 2000, 1000), "PLAYER TWO WINS");
            ObjBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }

    }

}
