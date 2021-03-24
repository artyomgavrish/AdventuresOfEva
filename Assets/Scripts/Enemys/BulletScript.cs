using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class BulletScript : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed = 10;
    [SerializeField] private Transform _rootTransform;
    [SerializeField] int _damage = 1;
    private CapsuleCollider _collider;

    public void SetDirection(Vector3 direction)
    {
        _direction = direction.normalized;
    }

    private void FixedUpdate()
    {
        if (_rootTransform == null)
            return;

        _rootTransform.Translate(_direction * (Time.deltaTime * _speed));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var enemy = other.GetComponent<PlayerMovement>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }
    }
}