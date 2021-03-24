using UnityEngine;

public class VectorDotAndCrossDemo : MonoBehaviour
{
    [SerializeField] private Transform _p1;
    [SerializeField] private Transform _p2;

    private void OnDrawGizmos()
    {
        if(_p1==null || _p2==null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, _p1.position);
        
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, _p2.position);
        
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, Vector3.Cross(_p1.position,_p2.position));
        
        Gizmos.color = Color.gray;
        Gizmos.DrawLine(Vector3.zero, Vector3.Cross(_p2.position,_p1.position));
        
        Gizmos.color = Color.white;
        
        Gizmos.DrawLine(Vector3.zero, Vector3.right * Vector3.Dot(_p1.position,_p2.position));
    }
}