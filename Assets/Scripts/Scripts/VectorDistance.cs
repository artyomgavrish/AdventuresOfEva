using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class VectorDistance : MonoBehaviour
{
    [SerializeField] private Vector3 _p1;
    [SerializeField] private Vector3 _p2;

    private void Start()
    {
        Debug.Log($"Distance: {Vector3.Distance(_p1,_p2)}");
        Debug.Log($"Magnitude: {(_p1-_p2).magnitude}");
        Debug.Log($"SQRMagnitude: {(_p1-_p2).sqrMagnitude}");
    }
}
