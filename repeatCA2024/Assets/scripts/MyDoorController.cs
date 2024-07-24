using AVR.Selection;
using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
    public GameObject mydoor;
    bool toggle;

    [SerializeField] 
    private Animator doorAnimation;


    public void openCloseDoor()
    {
        toggle = !toggle;
        if (toggle == false)
        {
            LetterUI.SetActive(false);
        }

        if (toggle == true)
        {
            LetterUI.SetActive(true);
        }




    }


}

