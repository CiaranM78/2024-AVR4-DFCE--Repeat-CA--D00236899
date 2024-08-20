using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AVR
{
    public class GameStateManager : MonoBehaviour
    {
        [SerializeField]
        private ObjectivesData objectivesData;

        [SerializeField]
        private InventoryData inventory;


        //  private Dictionary<inventory, ObjectivesData> ObjectiveDictionary;

        public void UpdateGameState()
        {
            foreach (var item in inventory.Data)
            {
                if (item.Equals(objectivesData.GetCurrentObjectiveData().ItemDatas))
                {
                    UpdateObjective();
                    break;
                }
            }

        }

        private void UpdateObjective()
        {
            if (objectivesData.IsLastObjective())
            {
                Time.timeScale = 0f;
            }
            else
            {
                objectivesData.IncrementObjective();
                
            }
        }



    }
}
