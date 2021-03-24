using UnityEngine;

public class QuaternionSlerp : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _from;
    [SerializeField] private Transform _to;
    
    // Start is called before the first frame update
    void Update()
    {
        if(_p1==null || _from ==null || _to==null)
            return;
        
        _p1.rotation = Quaternion.Slerp(_from.rotation, _to.rotation,     
            Time.time);

    }

}