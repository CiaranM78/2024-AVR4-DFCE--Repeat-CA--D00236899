using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class DoorBehaviour : ObjectiveBehaviour
    {
       
        [SerializeField]
        private ObjectivesData objectivesData;

        [SerializeField]
        private InventoryData inventory;


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

