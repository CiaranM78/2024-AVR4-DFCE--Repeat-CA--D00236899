using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectiveItemData",
     menuName = "AVR/Scriptable Objects/Game/ObjectItemData")]
public class ObjectiveData : ScriptableGameObject
{
    [SerializeField]
    private ItemData itemData;

    [SerializeField]
    private bool isObjectiveComplete;



    public ItemData ItemData
    {
        get { return itemData; }
    }

    public bool IsObjectiveComplete
    {
        get { return isObjectiveComplete; }
        set { isObjectiveComplete = value; }
    }

  
}
