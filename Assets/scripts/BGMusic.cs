using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BGMusic : MonoBehaviour
{
    private static BGMusic BackgroundMusic;

    void Awake()
    {
        if(BackgroundMusic == null)
        {
            BackgroundMusic = this;
            DontDestroyOnLoad(BackgroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
