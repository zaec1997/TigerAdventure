using NavMeshPlus.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameBehaviour : MonoBehaviour
{
    [SerializeField] NavMeshSurface surface;
    // Start is called before the first frame update
    void Start()
    {
        surface.BuildNavMesh();
       
    }

    private void FixedUpdate()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
}
