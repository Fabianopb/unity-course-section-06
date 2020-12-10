using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLayer : MonoBehaviour
{
    // Awake is called when the script instance is being loaded
    void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
