using UnityEngine;

public class QuaternionRotateAround : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _target;
    
    
    // Start is called before the first frame update
    void Update()
    {
        if(_p1==null || _target==null)
            return;
        
        _p1.RotateAround(_target.position, Vector3.up, 25 * 
                                                          Time.deltaTime);

    }

}