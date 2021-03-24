using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMagnitudeDemo : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _p2;

    private void OnDrawGizmos()
    {
        if(_p1==null || _p2==null)
            return;
        Gizmos.color = Color.red;
        
        Gizmos.DrawLine(Vector3.zero, Vector3.right * (_p1.position-_p2.position).magnitude);
        
        Gizmos.color = Color.white;
        
        Gizmos.DrawLine(_p1.position,_p2.position);
    }
}