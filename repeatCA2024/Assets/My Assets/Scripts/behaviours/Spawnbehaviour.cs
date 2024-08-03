using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



namespace AVR
{
    public class SpawnBehaviour : MonoBehaviour
    {

        [SerializeField]
        private Transform spawnpoint;

        [SerializeField]
        private GameObject spawnpointPrefab;



        // Start is called before the first frame update
        void Start()
        {
            Instantiate(spawnpointPrefab, spawnpoint.position, spawnpoint.rotation);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}