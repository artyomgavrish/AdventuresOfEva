using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRoom : MonoBehaviour
{
    // Start is called before the first frame update
     private void OnTriggerEnter(Collider  other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var enemy = other.GetComponent<MyEnemy>();
                       
            Destroy(gameObject);
        }
    }
}
