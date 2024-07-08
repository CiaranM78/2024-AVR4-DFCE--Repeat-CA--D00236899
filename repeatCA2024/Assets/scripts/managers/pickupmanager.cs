using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickupresponder : MonoBehaviour


{


    [SerializeField]
    private InventoryManager inventory;

    [SerializeField]
    private GameObject itemtest;



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("project test text");

        if (other.gameObject.CompareTag("pickup"))
        {


            Debug.Log("item picked up");

            inventory.Itemsize++;

            Destroy(other.gameObject);


        }


    }




}
