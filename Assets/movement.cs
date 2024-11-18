using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement : MonoBehaviour
{
    public GameObject o;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = o.transform.position;
        //transform.LookAt(o.transform.position);
        //transform.Translate(0, 0, 0.1f);

    }
}
