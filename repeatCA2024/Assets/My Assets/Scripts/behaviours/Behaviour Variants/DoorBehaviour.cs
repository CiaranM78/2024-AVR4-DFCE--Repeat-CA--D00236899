using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class DoorBehaviour : ObjectiveBehaviour
    {
   
        [SerializeField]
        private GameObject door;


        private void DoorUnlock()
        {
            Debug.Log("DoorUnlock");
            gameObject.SetActive(false);

        }

        protected override void HandleObjective()
        {
        DoorUnlock();
        
        }
}

