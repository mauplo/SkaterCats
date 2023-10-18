using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Para definir el audio que necesita cambios de volumen
    public AudioSource AudioSource;

    // La variable para el valor del volumen 
    private float musicVolume = 1f;

    // Actualizar el volumen con un valor del UI (slider)
    void Update()
    {
        AudioSource.volume = musicVolume;
    }  
    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }

}
