using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch1 : MonoBehaviour
{
   // funcion para reinicar el juego
    public void restartGame()
    {
        // indice del juego para cargar la escena de nuevo
        SceneManager.LoadScene(2);
    }
    // funcion para ir a menu
    public void mainMenu()
    {
        // indice de menu
        SceneManager.LoadScene(0);
    }
}
