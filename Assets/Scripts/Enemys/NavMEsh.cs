using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMEsh : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _Enemy;
    [SerializeField] private Transform _player;
    // Start is called before the first frame update
    void Start()
    {
        _Enemy.SetDestination(_player.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
