using NavMeshPlus.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshUpdate : MonoBehaviour
{
    private NavMeshSurface navMesh;
    // Start is called before the first frame update
    void Start()
    {
        navMesh = gameObject.GetComponent<NavMeshSurface>();
        navMesh.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
