using AVR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


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

  //  bool IsLastObjective() => CurrentObjective == objectivesList.Count() - 1;

    void IncrementObjective() 
    { CurrentObjective++; }

    public List<ObjectiveData> Objectives
        {
            get { return objectives; }
        }



    }


