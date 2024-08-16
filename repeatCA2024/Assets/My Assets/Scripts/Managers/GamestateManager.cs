using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameStateManager : Singleton<GameStateManager>
{
    [SerializeField]
    private ObjectivesData objectivesData;

    [SerializeField]
    private InventoryData inventory;


    //  private Dictionary<inventory, ObjectivesData> ObjectiveDictionary;

    public bool UpdateGameState()
    {
        foreach (var item in inventory.Data)
        {
            if (item.Equals(objectivesData.GetCurrentObjectiveData().ItemData))
            {
                UpdateObjective();
                return true;
            }

        }
        return false;
    }

    private void UpdateObjective()
    {
        if (objectivesData.IsLastObjective())
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene(0);
        }
        else
        {
            objectivesData.IncrementObjective();
            //  UIManager.Instance;
        }
    }

    public void Start()
    {
       
        objectivesData.ResetObjective();
    }

}


