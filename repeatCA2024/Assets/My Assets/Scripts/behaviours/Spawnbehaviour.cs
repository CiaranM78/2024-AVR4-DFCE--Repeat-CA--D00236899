using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



namespace AVR
{
    public class SpawnBehaviour : ObjectiveBehaviour
    {

        [SerializeField]
        private Transform spawnpoint;

        [SerializeField]
        private GameObject spawnpointPrefab;

        [SerializeField]
        private ObjectivesData objectivesData;

        [SerializeField]
        private InventoryData inventory;



        private void MedicineSpawn()
        {

            Debug.Log("medicine Spawned");
            Instantiate(spawnpointPrefab, spawnpoint.position, spawnpoint.rotation);
        }


        protected override void HandleObjective()
        {
           
            MedicineSpawn();
        }
    }
}