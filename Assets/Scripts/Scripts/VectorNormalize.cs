using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorNormalize : MonoBehaviour
{
    [SerializeField] private Vector3 _p1;
    [SerializeField] private Vector3 _p2;
    
    // Start is called before the first frame update
    void Start()
    {
        var direction = (_p2-_p1).normalized;
        Debug.Log($"Normalize: {direction}");
        Debug.Log($"Magnitude: {direction.magnitude}");
        
    }
}
