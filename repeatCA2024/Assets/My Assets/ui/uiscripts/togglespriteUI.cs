using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AVR
{

    public class togglespriteUI : MonoBehaviour

    {
        [SerializeField]
         GameObject currentUI;

        // Start is called before the first frame update
        void Start()
        {
            currentUI.SetActive(false);

        }

        void Update() {
            void OnTriggerEnter(Collider other)
            {
                if (other.gameObject.GetComponent<ItemBehaviour>() != null)


                    ToggleOnUI();


            }
        }
        private void ToggleOnUI()
        {
            currentUI.SetActive(true);
        }

        private void ToggleOffUI()
        {
            currentUI.SetActive(false);
        }

    }
}