using UnityEngine;

public class VectorDistanceDemo : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _p2;

    private void OnDrawGizmos()
    {
        if(_p1==null || _p2==null)
            return;
        Gizmos.color = Color.red;
        
        Gizmos.DrawLine(Vector3.zero, Vector3.right * (_p1.position-_p2.position).magnitude);
        
        Gizmos.color = Color.blue;
        
        Gizmos.DrawLine(Vector3.up, Vector3.right * Vector3.Distance(_p1.position,_p2.position) + Vector3.up);
        
        Gizmos.color = Color.green;
        
        Gizmos.DrawLine(Vector3.up*2, Vector3.right * (_p1.position-_p2.position).sqrMagnitude + Vector3.up*2);
        
        Gizmos.color = Color.white;
        
        Gizmos.DrawLine(_p1.position,_p2.position);
    }
}