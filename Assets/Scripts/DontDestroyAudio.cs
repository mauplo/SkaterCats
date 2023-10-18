using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    // variable estatica para checar si ya hay audio
    private static DontDestroyAudio instance;

    void Awake()
    {
        // si hay 1 solo audio, no destruye entre pantallas
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        // si hay mas de 1 audio, lo destruye
        else
        {
            Destroy(gameObject);
        }
    }
}
