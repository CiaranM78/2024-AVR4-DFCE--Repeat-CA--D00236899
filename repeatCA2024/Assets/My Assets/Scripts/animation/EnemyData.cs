using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(fileName = "EnemyData",
       menuName = "AVR/Scriptable Objects/Game/EnemyData")]

public class EnemyData : ScriptableGameObject
{
    [SerializeField]
    List<Vector3> waypoints;

    [SerializeField]
    [Range(0f, 7f)]
    private float speed ;

    private int currentWaypointIndex = 0;

    public float Speed
    {
        get { return speed; }
    }

    public int CurrentWaypointIndex
    {
        get { return currentWaypointIndex; }
        set { currentWaypointIndex = value; }
    }

    public List<Vector3> Waypoints

    {
        get { return waypoints; }
    }

}
