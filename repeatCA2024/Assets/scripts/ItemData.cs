using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AVR {

    [CreateAssetMenu(fileName = "ObjectiveItemData",
       menuName = "AVR/Scriptable Objects/Game/ItemData")]
    public class ItemData : ScriptableGameObject
    {
        [SerializeField]
        private string itemName;

        public string ItemName
        {
            get { return itemName; }
        }
       
    }


  


   
   








}
