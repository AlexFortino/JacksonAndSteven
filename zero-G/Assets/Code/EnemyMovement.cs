using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    public GameObject target;

    public float stopDistance = 1;
    // Start is called before the first frame update
    void Start()
    {
       target= GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log((Vector3.Distance(transform.position, target.transform.position)));
        if (Vector3.Distance(transform.position, target.transform.position) < stopDistance)
        {
            GetComponent<NavMeshAgent>().isStopped = true;
        }
        else { GetComponent<NavMeshAgent>().SetDestination(target.transform.position);
            GetComponent<NavMeshAgent>().isStopped = false;
        }
    }
}
