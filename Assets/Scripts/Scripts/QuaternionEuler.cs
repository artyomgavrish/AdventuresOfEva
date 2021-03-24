using UnityEngine;

public class QuaternionEuler : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    
    // Start is called before the first frame update
    void Start()
    {
        if(_p1==null)
            return;
        
        _p1.rotation = Quaternion.Euler(0,30,0);
    }

}