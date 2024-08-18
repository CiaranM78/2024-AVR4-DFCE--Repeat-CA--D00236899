using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectiveItemData",
     menuName = "AVR/Scriptable Objects/Game/ObjectItemData")]
public class ObjectiveData : ScriptableGameObject
{

    [SerializeField]
    private List<ItemData> itemDatas;

    [SerializeField]
    private bool isObjectiveComplete;

    [SerializeField]
    private string endDescription;

    public List<ItemData> ItemDatas
    {
        get { return itemDatas; }
    }

    public bool IsObjectiveComplete
    {
        get { return isObjectiveComplete; }
        set { isObjectiveComplete = value; }
    }

    public string EndDescription 
    { 
        get { return endDescription; }
        set { endDescription = value; }
    }

    public void SetCurrentObjectiveItems(bool isObjective)
    {
        foreach (var item in itemDatas)
        {
            item.IsObjective = isObjective;

        }
    }

}
