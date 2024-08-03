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

        public int CurrentObjective = 0;
        private object objectivesList;

    public ObjectiveData GetObjectiveData()
        {
        return objectives[CurrentObjective];
        }

    //public ObjectiveData SetObjectiveData()
    //{
    //    Text[objectives].gameObject.GetComponent<CurrentObjectiveEvent>().ItemData = objectives;
    //}

    //bool IsLastObjective()
    //{
    //    return CurrentObjective == objectivesList.Count() - 1;
    //}

    void IncrementObjective() 
    { 
        CurrentObjective++; 

    if ((bool)(objectivesList = 5)) 
        {

            SceneManager.LoadScene(1);

        }
    
    }

    public List<ObjectiveData> Objectives
        {
            get { return objectives; }
        }



    }


