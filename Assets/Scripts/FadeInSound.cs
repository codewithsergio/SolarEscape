using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInSound : MonoBehaviour
{
    public AudioSource audio;

    private float time;
    void Awake()
    {
        audio.volume = 0f;
    }

    void Update()
    {
        if(audio.volume < 1){
            audio.volume += 0.3f * Time.deltaTime;
        }
    }
}
