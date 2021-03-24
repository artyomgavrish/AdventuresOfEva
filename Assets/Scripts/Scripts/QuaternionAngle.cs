using UnityEngine;

public class QuaternionAngle : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _p2;
    
    // Start is called before the first frame update
    void Start()
    {
        if(_p1==null || _p2==null)
            return;
        
        Debug.Log(Quaternion.Angle(_p1.rotation,_p2.rotation));
    }

}