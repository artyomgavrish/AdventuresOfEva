using UnityEngine;

public class QuaternionLookRotation : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _target;
    
    // Start is called before the first frame update
    void Start()
    {
        if(_p1==null || _target==null)
            return;

        var relativePosition = _target.position - _p1.position;
        Quaternion rotation = Quaternion.LookRotation(relativePosition);
        _p1.rotation = rotation;
    }

}