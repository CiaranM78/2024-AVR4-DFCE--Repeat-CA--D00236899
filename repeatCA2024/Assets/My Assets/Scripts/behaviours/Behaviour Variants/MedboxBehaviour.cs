using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AVR
{

    public class MedboxBehaviour : ObjectiveBehaviour
    {
        [SerializeField]
        private GameEvent gameStateGameEvent;


        [SerializeField]
        private Transform spawnpoint;

        [SerializeField]
        private GameObject spawnpointPrefab;


        public void SpawnMedbox()
        {
            gameStateGameEvent.Raise();

            Instantiate(spawnpointPrefab, spawnpoint.position, spawnpoint.rotation);


        }

        protected override void HandleObjective()
        {
            SpawnMedbox();
        }


    }
}
