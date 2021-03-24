using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionIdentity : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    
    // Start is called before the first frame update
    void Start()
    {
        if(_p1==null)
            return;
        
        _p1.rotation = Quaternion.identity;
    }

}