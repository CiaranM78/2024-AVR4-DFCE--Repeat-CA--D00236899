using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace AVR {
    public class SoundOverlap : MonoBehaviour

    {

        private void Start()
        {
            SoundManager.Instance.PlaySoundOneShot(SoundType.MainTheme, 0.1f);
        }

        [SerializeField]
        private SoundType sound;
        private float volume;

        private void OnTriggerEnter(Collider other)
        {
            if (sound != SoundType.MainTheme)
            {
                SoundManager.Instance.StopSound(SoundType.MainTheme);
            }
            SoundManager.Instance.PlaySoundOneShot(sound);
        }



        private void OnTriggerExit(Collider other)
        {
            SoundManager.Instance.StopSound(sound);

            if (sound != SoundType.MainTheme)
            {
                SoundManager.Instance.PlaySoundOneShot(SoundType.MainTheme);
            }
        }


    }

}
