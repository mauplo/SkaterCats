using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    // variable para medir los fuegos artificiales que propelan la patineta
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    // variables para la patineta
    public Rigidbody2D carRigidbody;
    // variables para nuestras llantas
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    // valor para el movimiento de las llantas
    public float speed = 20;
    // valor para movimiento de la patineta
    public float carTorque = 10;
    // donde vamos a guardar el movimiento del jugador
    private float movement;
    // variable para controlar imagen de fuegos artificiales
    public UnityEngine.UI.Image image;

    // funcion para cambiar de escena
    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // recibir el input del jugador
        movement = Input.GetAxis("Horizontal");
        // la variable de la imagen se vuelve la cantidad de 'gasolina'
        image.fillAmount = fuel;
    }
    // funcion para mover las llantas
    private void FixedUpdate()
    {
        // si tenemos suficiente 'gasolina'
        if(fuel>0)
        {
            // Ajustar la velocidad y rotaciones de las llantas
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            // mover el coche en si
            carRigidbody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
        }

        // tenemos 0 de fuel
        else
        {
            // funcion para cambiar de escena (GameOver)
           ChangeScene(3);
        }

        // valor absoluto de la 'gasolina' requerida para moverse
        fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }

}
