using UnityEngine;

public class VectorNormalizeDemo : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _p2;

    private void OnDrawGizmos()
    {
        if(_p1==null || _p2==null)
            return;
        
        Gizmos.color = Color.white;
        
        Gizmos.DrawLine(_p1.position,_p2.position);
        
        Gizmos.color = Color.red;
        
        Gizmos.DrawLine(Vector3.zero, (_p2.position - _p1.position).normalized);
    }
}