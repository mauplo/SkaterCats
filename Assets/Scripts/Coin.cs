using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    // variable para texto de las monedas
    public Text MyscoreText;
    // variable para el numero de monedas
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        // el juego inicia con 0 monedas
        ScoreNum = 0;
        // lo ponemos en el texto
        MyscoreText.text = " " + ScoreNum;

    }
    // funcion para checar colision
    private void OnTriggerEnter2D(Collider2D Coin)
    {
        // tag 'MyCoin' en todas las monedas
        if(Coin.tag == "MyCoin")
        {
            // le anadimos 1 al score
            ScoreNum++;
            // desaparecemos la moneda
            Destroy(Coin.gameObject);
            // actualizamos el texto
            MyscoreText.text = " " + ScoreNum;
        }
    }

}
