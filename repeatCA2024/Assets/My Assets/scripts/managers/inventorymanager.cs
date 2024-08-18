using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace AVR
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField]
        private InventoryData inventory;

        [SerializeField]
        private InventoryData objectiveInventory;

        [SerializeField]
        private GameObject player;

        [SerializeField]
        private ObjectivesData objectivesData;

        private AbilityData currentActiveAbility;


        // creates a new list
        public void Start()
        {
            inventory.Data.Clear();
            objectiveInventory.Data.Clear();

        }

        private IEnumerator ActivateCoroutine()
        {
            yield return new WaitForSeconds(currentActiveAbility.Duration);
            currentActiveAbility.DeactivateAbility(player);
            currentActiveAbility = null;
        }

        //adds items name and description
        public void AddItem(ItemData item)
        {
            if(item.IsObjective)
            {
                objectiveInventory.Data.Add(item);
                UIManager.Instance.UpdateObjectives(item);

                if (objectiveInventory.Data.Count == objectivesData.GetCurrentObjectiveData().ItemDatas.Count)
                {
                    objectivesData.GetCurrentObjectiveData().IsObjectiveComplete = true;
                    UIManager.Instance.SetEndObjectiveText();

                }
            }
            else
            {
                inventory.Data.Add(item);
                UIManager.Instance.SetSprite(item);
            }
           
        }


        //removesitem from inventory
        public void RemoveItem(ItemData item)
        {
            if (item is AbilityData ability && currentActiveAbility == null)
            {
                currentActiveAbility = ability;
                inventory.Data.Remove(item);
                UIManager.Instance.RemoveSprite(item);
                currentActiveAbility.ActivateAbility(player);
                StartCoroutine(ActivateCoroutine());
            }

        }

        public int Size()
        {
            return inventory.Data.Count();

        }



    }
}


