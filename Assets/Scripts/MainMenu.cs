using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //Mixing Play Menu functions in here to save on having 1000 different scripts for every little thing
    public void PlaySPGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //I'm loading the next scene in queue rather than a specific one since this is for
        //the project deadline; once we have the full game, change this to load specific scene names
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game!");
        Application.Quit();
    }
}
