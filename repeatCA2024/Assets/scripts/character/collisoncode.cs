using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AVR
{
    public class PlayerCollision : MonoBehaviour
    {
        [SerializeField]
        private ObjectiveItemDataGameEvent addInventoryEvent;
        

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<ItemBehaviour>() != null)
            {
                addInventoryEvent.Raise(other.gameObject.GetComponent<ItemBehaviour>().ItemData);

                Destroy(other.gameObject);

               

            }

            if (other.CompareTag("destructable"))
            {
                
                Destroy(other.gameObject);
            }

          

        }


    }
}

