using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    // Para utilizar la base de datos
    public CharacterDatabase characterDB;

    // Referencia a los elementos de CharacterName y Selected Character en UI
    public Text nameText;
    public SpriteRenderer artworkSprite;

   // Variable para dar un indice a cada personaje 
    private int selectedOption = 0;

    // Start is called before the first frame update
    void Start()
    {
       // checar si ya hay un valor guardado
        if(!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }

        else
        {
            Load();
        }

        // funcion en linea 71 
        UpdateCharacter(selectedOption);
    }

    // Funcion para mover los personajes de manera progresiva (front button)
    public void NextOption()
    {
        // incrementar el indice por 1
        selectedOption++;
        // si el indice excede el numero de personaje que tenemos
        if(selectedOption >= characterDB.CharacterCount)
        {
            // regresamos al inicio.
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        Save();

    }

    // Funcion para mover los personajes de manera regresiva (back button)
    public void BackOption()
    {
        // restar el indice por 1
        selectedOption--;

        // si el indice es menor a cero, es que se ha restado mas que el indice total
        if(selectedOption < 0)
        {
            // regresa a un numero positivo
            selectedOption = characterDB.CharacterCount -1;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    // funcion para actualizar el nombre y sprite de los personajes
    private void UpdateCharacter(int selectOption)
    {
        // referencia a el character script y character DB
        Character character = characterDB.GetCharacter(selectedOption);
        // cambiar el sprite
        artworkSprite.sprite = character.characterSprite;
        // cambiar el nombre
        nameText.text = character.characterName;
    }
    private void Load()
    {
        // convertir indice a valor 
        selectedOption = PlayerPrefs.GetInt("selectedOption");

    }

    private void Save()
    {
        // Guardar el valor de la variable con su llave 
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    // funcion para cambiar de escena
    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}

