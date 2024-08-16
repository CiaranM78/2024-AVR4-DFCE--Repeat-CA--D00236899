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
            if (inventory.Data.Add(item))
            {
                UIManager.Instance.SetSprite(item);
            
            }
        }


        //removesitem from inventory
        public void RemoveItem(ItemData item)
        {
            inventory.Data.Remove(item);
            UIManager.Instance.RemoveSprite(item);
        }

        public int Size()
        {
            return inventory.Data.Count();

        }



    }
}
