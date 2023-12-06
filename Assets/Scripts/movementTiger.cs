using NavMeshPlus.Components;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;


public class movementTiger : MonoBehaviour
{
    private bool gameIsStarted;
    private NavMeshSurface navMesh;
    private NavMeshPath path;
    private GameObject Finish;
    private GameObject[] traps;
    private NavMeshAgent agent;
    private bool gameIsEnd;
    



    // Start iss called before the first frame update
    void Start()
    {
        gameIsStarted = true;
        path = new NavMeshPath();

        navMesh = GameObject.Find("NavMesh").GetComponent<NavMeshSurface>();
        Finish = GameObject.Find("Finish");
        traps = GameObject.FindGameObjectsWithTag("Trap");
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        gameIsEnd = false;








    }

    // Update is called once per frame
    void Update()
    {

        checkValidPath();


    }

    
    private void checkValidPath()
    {

        if (!gameIsEnd)
        {
            NavMesh.CalculatePath(gameObject.transform.position, Finish.transform.position, NavMesh.AllAreas, path);
            print(path.status);
            if (path.status == NavMeshPathStatus.PathComplete)
            {
                agent.SetDestination(Finish.transform.position);
                gameIsEnd = true;
            }


            if (!gameIsEnd) {
            foreach (GameObject trap in traps)
            {
                print(trap.transform.position);
                print(gameObject.transform.position);
                print(NavMesh.CalculatePath(gameObject.transform.position, trap.transform.position, NavMesh.AllAreas, path));
                print(path.status);
                if (path.status == NavMeshPathStatus.PathComplete)
                {
                    print(trap.transform.position);
                    print(path.status);
                    agent.SetDestination(trap.transform.position);
                    gameIsEnd = true;
                }
            }

        }

        }

    }

}
