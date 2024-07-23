
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AVR
{

    public class Letterinteraction : MonoBehaviour
    {
        [SerializeField]
        public float interactionDistance;
        [SerializeField]
        public GameObject interactionText;
        [SerializeField]
        public LayerMask interactionLayers;

        private void Update()
        {
            RaycastHit hit;
            Camera mainCamera = Camera.main;

            // Make sure the ray is cast from the camera's position
            if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, interactionDistance, interactionLayers))
            {
                Letterscript letterScript = hit.collider.gameObject.GetComponent<Letterscript>();

                if (letterScript != null)
                {
                    interactionText.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        letterScript.openCloseLetter();
                    }
                }
                else
                {
                    interactionText.SetActive(false);
                }
            }
            else
            {
                interactionText.SetActive(false);
            }
        }
    }
}