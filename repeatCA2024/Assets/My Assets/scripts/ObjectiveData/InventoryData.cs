using AVR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryData",
     menuName = "AVR/Scriptable Objects/Game/InventoryData")]
public class InventoryData : ScriptableGameObject
{
   public HashSet<ItemData> Data;
}