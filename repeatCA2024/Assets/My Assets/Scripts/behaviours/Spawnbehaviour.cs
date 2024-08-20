using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
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
        private PlayerController player;

        private void MedicineSpawn()
        {

            Debug.Log("medicine Spawned");
            Instantiate(spawnpointPrefab, spawnpoint.position, spawnpoint.rotation);
            player.Timer.SetEndTimer();
            player.GetComponent<NavMeshAgent>().speed = 10;
        }


        protected override void HandleObjective()
        {
           
            MedicineSpawn();
        }
    }
}