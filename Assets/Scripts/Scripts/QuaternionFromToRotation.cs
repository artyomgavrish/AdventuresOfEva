using UnityEngine;

public class QuaternionFromToRotation : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    
    // Start is called before the first frame update
    void Start()
    {
        if(_p1==null)
            return;
        
        _p1.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.right);
    }

}