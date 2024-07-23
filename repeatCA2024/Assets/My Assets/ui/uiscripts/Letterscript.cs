using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AVR
{

    public class Letterscript : MonoBehaviour
    {
        public GameObject LetterUI;
        bool toggle;

        public void openCloseLetter()
        {
            toggle = !toggle;
            if(toggle == false)
            {
                LetterUI.SetActive(false);
            }

            if (toggle == true)
            {
                LetterUI.SetActive(true);
            }




        }

    }
}