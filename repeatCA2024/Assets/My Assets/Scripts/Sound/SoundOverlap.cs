using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace AVR {
    public class SoundOverlap : MonoBehaviour

    {

        [SerializeField]
        private SoundType sound;

        private void OnTriggerEnter(Collider other)
        {
            AudioSFXManager.PlaySound(sound);
        }



        private void OnTriggerExit(Collider other)
        {
            AudioSFXManager.StopSound(sound);
        }


    }

}
