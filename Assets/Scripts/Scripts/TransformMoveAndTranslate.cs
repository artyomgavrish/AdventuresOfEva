using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMoveAndTranslate : MonoBehaviour
{
    
    [SerializeField] private float _speed = 1;

    [Header("References")] 
    [SerializeField]private Transform _transformMove;
    [SerializeField]private Transform _transformTranslateLocal;
    [SerializeField]private Transform _transformTranslateWorld;
    [SerializeField]private Transform _transformTranslateX;
    [SerializeField]private Transform _transformTranslateOther;
    [SerializeField]private Transform _transformMoveTowards;

    [Header("Helper references")]
    [SerializeField] private Transform _other;

    [SerializeField] private Transform _target;

    private void Update()
    {
        if (_transformMove == null || _transformTranslateLocal == null || _transformTranslateWorld == null ||
            _transformTranslateX == null || _transformTranslateOther == null || _other == null ||
            _transformMoveTowards == null || _target == null)
            return;
        
        _transformMove.position+=new Vector3(Time.deltaTime * _speed,0,0);
        _transformTranslateLocal.Translate(Vector3.right * (Time.deltaTime * _speed));
        _transformTranslateWorld.Translate(Vector3.right * (Time.deltaTime * _speed),Space.World);
        _transformTranslateX.Translate(Time.deltaTime * _speed,0,0);
        _transformTranslateX.Translate(Time.deltaTime * _speed,0,0);
        _transformTranslateOther.Translate(Vector3.right * (Time.deltaTime * _speed),_other);
        _transformMoveTowards.position =
            Vector3.MoveTowards(_transformMoveTowards.position, _target.position, _speed * Time.deltaTime);

    }
}
