using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectBehaviour : ObjectiveBehaviour
{
    [SerializeField]
    private ObjectivesData objectivesData;

    [SerializeField]
    private InventoryData inventory;

    [SerializeField]
    private GameObject objectiveDoor;


    private void ItemDestroy()
    {
        Debug.Log("itemdestroyed");
        gameObject.SetActive(false);
    }

    private void DoorUnlock()
    {
        Debug.Log("DoorUnlock");
        objectiveDoor.SetActive(false);
    }

    protected override void HandleObjective()
    {
        ItemDestroy();
        //objectsDestroyed();
        DoorUnlock();
    }
}
