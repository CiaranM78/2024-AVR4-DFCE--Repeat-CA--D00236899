using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AreaBehaviour : ObjectiveBehaviour
{

    [SerializeField]
    private ObjectivesData objectivesData;

    [SerializeField]
    private InventoryData inventory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HandleObjective();
        }

    }

    protected override void HandleObjective()
    {

    }


}

