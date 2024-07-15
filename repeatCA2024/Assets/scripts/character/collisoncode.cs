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
            if (other.gameObject.GetComponent<itembehaviour>() != null)
            {
                addInventoryEvent.Raise(other.gameObject.GetComponent<itembehaviour>().ObjectiveItemData);

                Destroy(other.gameObject);
            }

        }

      
    }
}

