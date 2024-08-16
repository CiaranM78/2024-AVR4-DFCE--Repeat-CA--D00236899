using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectBehaviour : ObjectiveBehaviour
{

    [SerializeField]
    private ObjectivesData objectivesData;

    [SerializeField]
    private InventoryData inventory;


    //[SerializeField]
    //private List<GameObject> objectsToDestroy;





    //public void ObjectDestroyed(GameObject destroyedObject)
    //{
    //    objectsToDestroy.Remove(destroyedObject);

    //    if (objectsToDestroy.Count == 0)
    //    {
    //        Debug.Log("all objects destroyed");
    //    }
    //}


    private void ItemDestroy()
    {
        Debug.Log("itemdestroyed");
        gameObject.SetActive(false);
    }



    protected override void HandleObjective()
    {
        ItemDestroy();
    }
}
