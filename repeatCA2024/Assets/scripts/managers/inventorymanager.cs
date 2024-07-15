using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace AVR
{
    public class InventoryManager : MonoBehaviour
    {
        List<ObjectiveItemData> itemList;



        // creates a new list
        public void Start()
        {
            itemList = new List<ObjectiveItemData>();
        }


        //adds items name and description
        public void AddItem(ObjectiveItemData item)
        {
            itemList.Add(item);

            Debug.Log(item.name);
            Debug.Log(item.Description);
        }


        //removesitem from inventory
        public void RemoveItem(ObjectiveItemData item)
        {
            itemList.Remove(item);
        }

        public int Size()
        {
            return itemList.Count();

        }

    }
}
