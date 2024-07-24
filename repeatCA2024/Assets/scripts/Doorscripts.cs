using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace AVR { 
public class Door : MonoBehaviour
{
   
       public GameObject DoorObject;
        bool toggledoor;

        public void openCloseDoor()
        {
            toggledoor = !toggledoor;
            if (toggledoor == false)
            {
                DoorObject.SetActive(false);
            }

            if (toggledoor == true)
            {
                DoorObject.SetActive(true);
            }




        }

    }
}
