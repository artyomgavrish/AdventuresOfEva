using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{

    [SerializeField] int _damage = 1;
    private CapsuleCollider _collider;
    private void OnTriggerEnter(Collider  other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);            
            Destroy(gameObject);
        }
    }


}
