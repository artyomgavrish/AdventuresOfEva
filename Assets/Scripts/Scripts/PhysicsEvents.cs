using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEvents : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{gameObject.name} OnTriggerEnter with {other.name} ");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"{gameObject.name} OnTriggerStay with {other.name} ");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"{gameObject.name} OnTriggerExit with {other.name} ");
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"{gameObject.name} OnCollisionEnter with {other.collider.name} ");
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log($"{gameObject.name} OnCollisionStay with {other.collider.name} ");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log($"{gameObject.name} OnCollisionExit with {other.collider.name} ");
    }
}
