using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioSFXManager : MonoBehaviour
{
public AudioSource AmbianceSource, sfxsource;
public SoundScript[] ambiance, SfX;



    public static AudioSFXManager instance;

    public void Awake()
    {
        instance = this;

    }
    public void PlayMusic(string soundName)
    {
        SoundScript sound = Array.Find(ambiance, x => x.soundname == soundName);

        if (sound == null )
        {
            Debug.Log("sound not found");
        }
        else
        {
            AmbianceSource.clip = sound.clip;
            AmbianceSource.Play();
        }
    }

    public void PlaySFX(string soundName)
    {
        SoundScript sound = Array.Find(ambiance, x => x.soundname == soundName);

        if (sound == null)
        {
            Debug.Log("sound not found");
        }
        else
        {
            sfxsource.PlayOneShot(sound.clip)
            ;
        }
    }

}
