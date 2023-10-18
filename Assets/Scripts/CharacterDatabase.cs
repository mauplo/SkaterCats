using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear base de datos para personajes
[CreateAssetMenu]

// EL script no va  a ser para GameObjects
public class CharacterDatabase : ScriptableObject
{
    // LLama a script de Character
   public Character[] character;

   // Numero de personajes en el juego
   public int CharacterCount
   {
       get
       {
           return character.Length;
       }
   }

    // Recuperar informacion del personaje seleccionado
   public Character GetCharacter(int index)
   {
       return character [index];
   }
}


