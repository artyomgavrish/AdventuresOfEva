using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyEnemy : MonoBehaviour
{   
   [SerializeField] private Transform enemySpawnPlace;
   [SerializeField] private GameObject enemy;
   [SerializeField] int _health = 1;
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    int m_CurrentWaypointIndex;
    void Start(){
        navMeshAgent.SetDestination (waypoints[0].position);
    }

    void Update ()
    {
        if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
        }
    }

    public void Hurt(int damage)
    {
        print("Ouch: " + damage);

        _health -= damage;

        if (_health <= 0)
        {
            Die();
            create();
        }
    }

    private void create(){
        _health = 1;
        enemy.GetComponent<NavMeshAgent>().enabled = true;
        enemy.GetComponent<MyEnemy>().enabled = true;
        Instantiate(enemy, enemySpawnPlace.position, Quaternion.identity);
        
        
    }

    private void Die ()
    {
        Destroy(gameObject);
    }
}