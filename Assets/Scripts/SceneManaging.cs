using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
   public void start() // it goes to Character Selection Pannel Scene.
    {
        SceneManager.LoadScene("Character Selection Pannel");
    }

    public void exit() // exit button and turns off the game.
    {
        Application.Quit();
    }

}   