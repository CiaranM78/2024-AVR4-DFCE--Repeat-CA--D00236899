using UnityEngine;

namespace AVR
{
    public class ObjectiveLabel : MonoBehaviour
    {

        private ItemData itemData;

        public ItemData ItemData
        {
            get { return itemData; }
            set { itemData = value; }
        }
    }
}