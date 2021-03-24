using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GirlZombie : MonoBehaviour
{
    [SerializeField] private Transform _girlZombie;
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _start;
    [SerializeField] private float _distance;
    [SerializeField] private float _distance1;
    [SerializeField] private Vector3 _d1;
    [SerializeField] private Vector3 _d2;
    [SerializeField] private Vector3 _d3;
    NavMeshAgent navMeshAgent;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {    
        _d1 = _target.position;
        _d2 = _girlZombie.position;
        _d3 = _start.position;
        _distance = Mathf.Sqrt((_d1 - _d2).sqrMagnitude);
        if (_distance < 5)
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            navMeshAgent.SetDestination(_d1);
            animator.SetFloat("Speed", navMeshAgent.velocity.magnitude);
            animator.SetFloat("Distance", _distance);
        }
        else
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            navMeshAgent.SetDestination(_d3);
            _distance1 = Mathf.Sqrt((_d3 - _d2).sqrMagnitude);
            if(_distance1 < 1)
            {
                animator.SetFloat("Speed", 0);
            }

        }
        }
}
