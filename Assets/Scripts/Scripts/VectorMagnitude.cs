using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMagnitude : MonoBehaviour
{
    [SerializeField] private Vector2 _vector2D;
    [SerializeField] private Vector3 _vector3D;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Vector2D: {_vector2D.magnitude}");   
        Debug.Log($"Vector3D: {_vector3D.magnitude}");   
    }
}
