
using AVR.Selection;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;


namespace AVR
{

    public class Letterinteraction : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        private float interactionDistance;
        [SerializeField]
        private GameObject interactionText;
        [SerializeField]
        private LayerMask interactionLayers;

        public void OnDeselect(Transform transform)
        {
            interactionText.SetActive(false);
        }

        public void OnSelect(Transform transform)
        {
            Letterscript letterScript = transform.gameObject.GetComponent<Letterscript>();

            if (letterScript != null)
            {
                interactionText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    letterScript.openCloseLetter();
                }
            }

        }

      
    }
}