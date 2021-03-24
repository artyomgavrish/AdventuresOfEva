using UnityEngine;

public class QuaternionRotateTowards : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _target;
    
    // Start is called before the first frame update
    void Update()
    {
        if(_p1==null || _target==null)
            return;
            
        
        Vector3 targetDir = _target.position - _p1.position;

        Vector3 newDir = Vector3.RotateTowards(_p1.forward, targetDir, _speed * Time.deltaTime, 1);
        Debug.DrawRay(_p1.position, newDir, Color.red);

        _p1.rotation = Quaternion.LookRotation(newDir);

    }

}