using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameStateManager : Singleton<GameStateManager>
{
    [SerializeField]
    private ObjectivesData objectivesData;

    //  private Dictionary<inventory, ObjectivesData> ObjectiveDictionary;

    public bool UpdateGameState()
    {
        if (objectivesData.GetCurrentObjectiveData().ItemDatas.Count == 0)
        {
            objectivesData.GetCurrentObjectiveData().IsObjectiveComplete = true;
        }
        return objectivesData.GetCurrentObjectiveData().IsObjectiveComplete;
    }

    public void IncrementObjective()
    {
   
        if (objectivesData.IsLastObjective())
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene(0);
        }
        else
        {
            objectivesData.IncrementObjective();
            UIManager.Instance.SetObjectiveText();
        }
    }

    public void Awake()
    {
       
        objectivesData.ResetObjective();
    }

}


