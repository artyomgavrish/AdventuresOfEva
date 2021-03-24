using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
        [SerializeField] int _heal = 1;

    private void OnTriggerEnter(Collider  other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerMovement>();
            player.Heal(_heal);            
            Destroy(gameObject);
        }
    }
}
