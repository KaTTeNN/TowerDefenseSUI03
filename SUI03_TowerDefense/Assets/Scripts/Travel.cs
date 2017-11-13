using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Travel : MonoBehaviour
{

    [SerializeField]
    Transform[] targets;
    int targetCounter = 0;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(targets[0].position);
    }

    // Update is called once per frame
    void Update()
    {

        if (targetCounter < targets.Length - 1)
        {
            if (gameObject.GetComponent<NavMeshAgent>().remainingDistance <= 0)
            {
                targetCounter++;
                gameObject.GetComponent<NavMeshAgent>().SetDestination(targets[targetCounter].position);
            }
        }
    }

}
