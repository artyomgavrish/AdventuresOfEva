using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TurretScrip : MonoBehaviour
{

    [SerializeField] private Transform _turret;
    [SerializeField] private Transform _target;
    [SerializeField] private float _distance;
    [SerializeField] private Vector3 _d1;
    [SerializeField] private Vector3 _d2;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private BulletScript _bullet;    
    [SerializeField] private float _shootPeriod = .5f;
    [SerializeField] private Transform _rootTransform;
    public float bulletSpeed = 10;
    //public Rigidbody bullet;
    private float _lastShot;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(_turret==null || _target==null)
        return;
        _turret.LookAt(_target);

        _d1 = _target.position;
        _d2 = _turret.position;
        _distance = Mathf.Sqrt((_d1 - _d2).sqrMagnitude);
        //print(_distance);
        if (_bullet == null || _rootTransform == null)
            return;
        while (_distance < 5)//пока дистанция меньше 5 стреляем по персонажу, когда больше не стреляем
        {
            if(Time.time<_lastShot + _shootPeriod)
            return;
            _lastShot = Time.time;
           Fire();
        }
        
    }

     void Fire()
     {

        Vector3 relativePos = _target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        var bulletClone = Instantiate(_bullet, _shootPoint.position, rotation);
        bulletClone.SetDirection(_rootTransform.forward);
        
        
     }

}
