using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1 : MonoBehaviour
{
    [SerializeField] int _damage = 5;
    private CapsuleCollider _collider;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var enemy = other.GetComponent<PlayerMovement>();
            enemy.Hurt(_damage);
            
        }
    }
}
