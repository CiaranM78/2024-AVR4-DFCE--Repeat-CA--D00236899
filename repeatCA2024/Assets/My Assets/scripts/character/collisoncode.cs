using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class PlayerCollision : MonoBehaviour
    {
        [SerializeField]
        private ObjectiveItemDataGameEvent addInventoryEvent;

        [SerializeField]
        private ObjectivesData objectivesData;

        [SerializeField]
        private InventoryData inventory;

        [SerializeField]
        private NoteDataGameEvent noteDataUIEvent;

        //[SerializeField]
        //private togglespriteUI

        //[SerializeField]
        //private bool ItemPickedup;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<ItemBehaviour>() != null)
            {
                ItemData itemdata = other.gameObject.GetComponent<ItemBehaviour>().ItemData;


            if (itemdata is NoteData)
            {
                noteDataUIEvent.Raise(itemdata as NoteData);

            }
            addInventoryEvent.Raise(other.gameObject.GetComponent<ItemBehaviour>().ItemData);

                
                UIManager.Instance.SetSprite(other.gameObject.GetComponent<ItemBehaviour>().ItemData);
                Destroy(other.gameObject);

            }

            if (other.CompareTag("destructable"))
            {
                
                Destroy(other.gameObject);
            }

            if (other.CompareTag("Objective"))
            {
                if (inventory.Data.Contains(objectivesData.GetObjectiveData().ItemData)) {

                    Debug.Log("Objective Complete");
                    objectivesData.GetObjectiveData().IsObjectiveComplete = true;

                   
                    //togglespriteUI.ToggleOnUI().ItemPickedup = true;
                        
                    Destroy(other.gameObject);

                

                }


                
            }

        }


        
    }


