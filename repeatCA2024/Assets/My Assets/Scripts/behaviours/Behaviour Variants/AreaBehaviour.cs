using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class AreaBehaviour : ObjectiveBehaviour
{

    [SerializeField]
    private ObjectivesData objectivesData;

    [SerializeField]
    private InventoryData inventory;

    private void MedicineDelivered()
    {
        SceneManager.LoadScene(0);
    }

    protected override void HandleObjective()
    {
        MedicineDelivered();
    }


}

