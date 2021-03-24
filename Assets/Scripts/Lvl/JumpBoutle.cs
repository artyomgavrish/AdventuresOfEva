using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoutle : MonoBehaviour
{
    [SerializeField] int jumpUpdate = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerMovement>();
            player.JumpBoost(jumpUpdate);
            Destroy(gameObject);
        }
    }
}
