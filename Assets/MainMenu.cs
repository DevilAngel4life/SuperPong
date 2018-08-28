using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string newGameScene;                 // New Game input Assigment 
    public string HelpGameScene;                // Help Scene input  Assigment from Unity


    public void NewGame()                       // NewGame() called when a buttom is pressed to load the newGameScene
    {
        SceneManager.LoadScene(newGameScene);
    }

    public void Help()                          // Help() called when a buttom is pressed to load the HelpGameScene
    {
        SceneManager.LoadScene(HelpGameScene);
    }

    public void QuitGame()                      // QuitGame() called when a buttom is pressed to quit the application 
    {
        Application.Quit();
    }
}
