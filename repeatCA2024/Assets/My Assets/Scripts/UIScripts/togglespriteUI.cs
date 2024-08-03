using AVR.Selection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AVR
{

    public class togglespriteUI : MonoBehaviour
    {

        public GameObject currentUI;

        [SerializeField]
        private bool ItemPickedup;

        // Start is called before the first frame update
        void Start()
        {
            //currentUI.SetActive(false);

        }

        void Update() {

            //  AudioSFXManager.instance.PlayMusic("gerryadams");
        }

        public bool IsItemPickedup
        {
            get { return ItemPickedup; }
            set { ItemPickedup = value; }
        }

        public void ToggleOnUI(bool itemPickedup)
        {
            if (ItemPickedup == true)
            {
                currentUI.SetActive(true);
            }
        }

        private void ToggleOffUI()
        {
            currentUI.SetActive(false);
        }
    
      
    }
}