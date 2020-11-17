using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){ //Loading the menu
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame(){ //Quiting the game if the quit button has been pressed
    	Debug.Log("QUIT!");
    	Application.Quit();
    }
}
