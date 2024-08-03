using AVR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.My_Assets.Scripts.Controllers
{
    public class RemoveItemController : MonoBehaviour  
    {

     
        private ItemData itemData;

        [SerializeField]
        private ObjectiveItemDataGameEvent removeGameEvent;

       public ItemData ItemData 
        {
            get { return itemData; }
            set { itemData = value; }
        }

        public void RemoveItem()
        {
            removeGameEvent.Raise(itemData);
            
        }

    }
}
