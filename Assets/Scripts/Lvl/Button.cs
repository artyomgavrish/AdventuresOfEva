using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    [SerializeField] private string _tag = "Player";

    public UnityEvent OnTriggerEnterEvent;
    public UnityEvent OnTriggerExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_tag))
        {
            OnTriggerEnterEvent.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(_tag))
        {
            OnTriggerExitEvent.Invoke();
        }
    }
}
