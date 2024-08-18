using AVR;
using System;
using UnityEngine;
using UnityEngine.UI;



[CreateAssetMenu(fileName = "ObjectiveItemData",
       menuName = "AVR/Scriptable Objects/Game/ItemData")]
    public class ItemData : ScriptableGameObject
    {
        [SerializeField]
        private string itemName;

        [SerializeField]
        private Sprite spriteIcon;

        public bool IsObjective;

        public string ItemName
        {
            get { return itemName; }
        }

        public Sprite SpriteIcon
        {
            get { return spriteIcon; }
        }

   
}
