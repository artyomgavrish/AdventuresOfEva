using UnityEngine;

public class QuaternionLookAt : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _target;
    [SerializeField] private float _distance;
    
    // Start is called before the first frame update
    void Update()
    {
        if(_p1==null || _target==null)
            return;
        
        _p1.LookAt(_target);


    }

}