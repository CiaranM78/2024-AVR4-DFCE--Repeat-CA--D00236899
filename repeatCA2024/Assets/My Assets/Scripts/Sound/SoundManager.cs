using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.Rendering;


namespace AVR
{

    public enum SoundType
    {
        MedicalFacility,
        UFO,
        MainTheme,
        SFX
    }

    // [RequireComponent(typeof(AudioSource))]
    public class SoundManager : Singleton<SoundManager>
    {
       
        private AudioSource audioSource;


        [SerializeField] Slider volumeslider;
   
        [SerializeField]
        private SoundDictionary soundDictionary;

  

        private void Start()
        {
   
            audioSource = GetComponent<AudioSource>();
          
        }

        public void PlaySound(SoundType sound, float volume = 0.5f)
        {
            audioSource.PlayOneShot(soundDictionary.GetAudioClip(sound), volume);
        }

        public void StopSound(SoundType sound)
        {
            audioSource.Stop();
        }

        public void ChangeVolume(float volume)
        {
            AudioListener.volume = volume;
        }

     

       

    }
}