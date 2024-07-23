using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectiveItemData",
      menuName = "AVR/Scriptable Objects/Game/Objectives")]
public class ObjectiveDatas : ScriptableGameObject
{
    [SerializeField]
    private List<ObjectiveData> objectives;

    public int CurrentObjective;

    public ObjectiveData GetObjectiveData()
    {
        return objectives[CurrentObjective];
    }

    public List<ObjectiveData> Objectives
    {
        get { return objectives; }
    }

    

}
