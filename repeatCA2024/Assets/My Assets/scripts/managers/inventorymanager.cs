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
        [SerializeField]
        private InventoryData inventory;
        

        // creates a new list
        public void Start()
        {
           inventory.Data.Clear();
        }


        //adds items name and description
        public void AddItem(ItemData item)
        {
            inventory.Data.Add(item);

            Debug.Log(item.name);
            Debug.Log(item.Description);
        }


        //removesitem from inventory
        public void RemoveItem(ItemData item)
        {
            inventory.Data.Remove(item);
        }

        public int Size()
        {
            return inventory.Data.Count();

        }

        //public void ObjectiveStatus()
        //{
        //    if (objectiveDatas != null)
        //    {
        //        for ()
        //        objectiveDatas.
                
        //    }
        //}


    }
}
