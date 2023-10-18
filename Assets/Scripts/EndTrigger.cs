using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    // funcion para detectar si algo toco la bandera
    void OnTriggerEnter2D(Collider2D collision)
  {
      // funcion para cambiar de screen
      SceneManager.LoadScene(4);
  }
  
}
