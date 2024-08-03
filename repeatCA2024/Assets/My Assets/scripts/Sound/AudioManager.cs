using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


namespace AVR
{

    public enum SoundType
    {
        MedicalFacility,
        UFO,
        MainTheme,
        SFX
    }

    [RequireComponent(typeof(AudioSource))]
    public class AudioSFXManager : MonoBehaviour
    {
        private static AudioSFXManager _instance;
        private AudioSource _audioSource;


        [SerializeField] Slider volumeslider;
        [SerializeField] private AudioClip[] soundList;



        private Dictionary<SoundType, AudioClip> soundDictionary;

        public static AudioSFXManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.LogError("AudioSFXManager is NULL");
                }
                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                
            }
            else
            {
                Destroy(gameObject);
            }

            _audioSource = GetComponent<AudioSource>();
            soundDictionary = new Dictionary<SoundType, AudioClip>();

            for (int i = 0; i < soundList.Length; i++)
            {
                soundDictionary[(SoundType)i] = soundList[i];
            }
        }

        public static void PlaySound(SoundType sound, float volume = 0.5f)
        {
            if (Instance.soundDictionary.TryGetValue(sound, out var clip))
            {
                Instance._audioSource.PlayOneShot(clip, volume);
            }
            else
            {
                Debug.LogWarning($"Sound {sound} not found in the dictionary.");
            }
        }

        public static void StopSound(SoundType sound)
        {
            Instance._audioSource.Stop();
        }

        public void ChangeVolume(float volume)
        {
            AudioListener.volume = volumeslider.value;
        }

        public void Update()
        {
            volumeslider.value = AudioListener.volume;
        }

    }
}