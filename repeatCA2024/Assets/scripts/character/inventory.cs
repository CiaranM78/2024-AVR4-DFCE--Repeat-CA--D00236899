using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Inventory", menuName = "Scriptable Objects/inventory")]

public class InventoryManager : ScriptableObject
{

    void Start()
    {




    }

    public int Itemsize = 0;

    // core items

    public int medicine = 0;
    public int medboxkey = 0;
    public int wireclippers = 0;
  

    // items that help overcome obstacles

    public int mop = 0;
    public int hammer = 0;
    public int planks = 0;


}
