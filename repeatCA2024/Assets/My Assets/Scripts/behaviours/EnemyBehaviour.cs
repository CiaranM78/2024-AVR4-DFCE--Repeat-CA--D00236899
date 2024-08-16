using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private EnemyData enemydata;

    [SerializeField]
    LayerMask playerLayerMask;

    [SerializeField]
    private float detectionRange;

    [SerializeField]
    private float detectionRadius;

    private void Start()
    {
        enemydata.CurrentWaypointIndex = 0;
        transform.position = enemydata.Waypoints[enemydata.CurrentWaypointIndex];
        
    }

    private IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds (1);
        SceneManager.LoadScene(2);
    }


    private void Update()
    {
        MoveTowardsWaypoint();
        DetectPlayer();
    }

    private void MoveTowardsWaypoint()
    {

        Vector3 targetPosition = enemydata.Waypoints[enemydata.CurrentWaypointIndex];


        Vector3 direction = (targetPosition - transform.position).normalized;

        // Rotate towards the target waypoint
        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5f * Time.deltaTime);
        }

        // Move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, enemydata.Speed * Time.deltaTime);

        // Check if the enemy has reached the waypoint
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {

            enemydata.CurrentWaypointIndex++;

            // Loop back to the first waypoint if we reached the end
            if (enemydata.CurrentWaypointIndex >= enemydata.Waypoints.Count)
            {
                enemydata.CurrentWaypointIndex = 0;
            }
        }

    }

    private void DetectPlayer()
    {
        // Define the sphere cast parameters
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        // Perform the sphere cast
        if (Physics.SphereCast(origin, detectionRadius, direction, out RaycastHit hit, detectionRange, playerLayerMask,QueryTriggerInteraction.UseGlobal))
        {
            // Check if the sphere cast hit an enemy
            Debug.Log($"Enemy detected: {hit.collider.gameObject.name}");

            StartCoroutine(GameOverDelay());

            // You can add your logic here, e.g., attack the enemy or change behavior
        }
    }

    private void OnDrawGizmos()
    {
        // Visualize the detection sphere in the editor
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.forward * detectionRange);
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }

}



