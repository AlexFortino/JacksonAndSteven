using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    public GameObject target;

    private bool canAttack = true;

    public float stopDistance = 1;
    // Start is called before the first frame update
    void Start()
    {
       target= GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
            //GetComponent<NavMeshAgent>().SetDestination(target.transform.position);
            Debug.Log((Vector3.Distance(transform.position, target.transform.position)));
        if (Vector3.Distance(transform.position, target.transform.position) < stopDistance)
        {
            GetComponent<NavMeshAgent>().isStopped = true;
            if (canAttack)
            {
                target.GetComponent<Health>().takeDamage(1);
                canAttack = false;
                Invoke("AttackCooldown", 3);
            }
        }
        else
        {
            GetComponent<NavMeshAgent>().SetDestination(target.transform.position);
            GetComponent<NavMeshAgent>().isStopped = false;
        }
    }
    void AttackCooldown()
    {
        canAttack = true;
    }
}
