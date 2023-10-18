using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    
    // Boton de Start lleva a la proxima escena (+1 en index)
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Boton de quit termina el juego
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
