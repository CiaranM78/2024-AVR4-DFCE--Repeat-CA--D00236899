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
        List<ItemData> itemList;
        [SerializeField]
        private ObjectiveDatas objectiveDatas;



        // creates a new list
        public void Start()
        {
            itemList = new List<ItemData>();
        }


        //adds items name and description
        public void AddItem(ItemData item)
        {
            itemList.Add(item);

            Debug.Log(item.name);
            Debug.Log(item.Description);
        }


        //removesitem from inventory
        public void RemoveItem(ItemData item)
        {
            itemList.Remove(item);
        }

        public int Size()
        {
            return itemList.Count();

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
