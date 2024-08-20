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
        Note,
        PowerUp
    }
    public class SoundManager : Singleton<SoundManager>
    {

        private AudioSource audioSource;


        [SerializeField] 
        private AudioSource backroundAudioSource;
   
        [SerializeField]
        private SoundDictionary soundDictionary;

  

        private void Start()
        {
   
            audioSource = GetComponent<AudioSource>();
          
        }

        public void PlaySoundOneShot(SoundType sound, float volume = 0.5f)
        {
            audioSource.PlayOneShot(soundDictionary.GetAudioClip(sound), volume);
        }


        public void PlaySound(SoundType sound)
        {
            backroundAudioSource.clip = soundDictionary.GetAudioClip(sound);
            backroundAudioSource.Play();
        }

        public void StopSound(SoundType sound)
        {
            backroundAudioSource.Stop();
        }

        public void ChangeVolume(float volume)
        {
            AudioListener.volume = volume;
        }

     

       

    }
}