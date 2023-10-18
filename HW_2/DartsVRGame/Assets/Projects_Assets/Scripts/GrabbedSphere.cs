using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class GrabbedSphere : MonoBehaviour
{
    public GameObject table;
    void Start()
    {
        
    }

    void Update()
    {
        if(Vector3.Distance(gameObject.transform.position, table.transform.position) <= 0)
        {
            Debug.Log("Touched the table");
        }
    }
}
