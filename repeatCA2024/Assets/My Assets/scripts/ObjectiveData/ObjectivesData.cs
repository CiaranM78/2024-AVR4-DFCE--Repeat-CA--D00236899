using AVR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.My_Assets.Scripts.Controllers;
using TMPro;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "ObjectivesData",
          menuName = "AVR/Scriptable Objects/Game/ObjectivesData")]
    public class ObjectivesData : ScriptableGameObject
    {
        [SerializeField]
        private List<ObjectiveData> objectives;

        [SerializeField]
        private int currentObjective = 0;

    



    public ObjectiveData GetCurrentObjectiveData()
        {
        if (currentObjective >= 0 && currentObjective < objectives.Count)
        {
            return objectives[currentObjective];
        }
        else
        {
            return null;
        }
    }



    public bool IsLastObjective()
    {
        return currentObjective == objectives.Count() - 1;
    }

    public void IncrementObjective() 
    {
        currentObjective++; 
    
    }

    public void ResetObjective()
    {
        
        currentObjective = 0;

    }


}


