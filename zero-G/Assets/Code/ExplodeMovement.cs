using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ExplodeMovement : MonoBehaviour
{
    public GameObject target;

    public ParticleSystem explosion;

    private bool canAttack = true;

    private bool ifDead = false;

    public float ChargingDistance = 5;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");

        GetComponent<NavMeshAgent>().baseOffset = Random.Range(0.5f, 3);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (gameObject.GetComponent<Health>().health <= 0)
        {
            death();
        }
        if (!ifDead)
        {
            
            RaycastHit hit;
            int layermask = 1 << 3;
            layermask = ~layermask;
            Vector3 direction = target.transform.position - transform.position;
            if (Vector3.Distance(transform.position, target.transform.position) < ChargingDistance && Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity, layermask))
            {
                Debug.Log("stopping");
                Debug.Log(hit);
                if (hit.collider.gameObject.name == "body")
                {
                    GetComponent<NavMeshAgent>().isStopped = true;
                    GetComponent<NavMeshAgent>().enabled = false;
                    transform.LookAt(target.transform.position);
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
                    Debug.Log("hit the player");
                    Debug.DrawRay(transform.position, direction * hit.distance, Color.red);
                    Debug.Log(hit.collider.gameObject.name);
                    //    //if (canAttack)
                    //    //{
                    //    //    target.GetComponent<Health>().takeDamage(1);
                    //    //    canAttack = false;
                    //    //    Invoke("AttackCooldown", 3);
                }
            }


                //}
            else
            {
                GetComponent<NavMeshAgent>().enabled = true;
                GetComponent<NavMeshAgent>().SetDestination(target.transform.position);
                GetComponent<NavMeshAgent>().isStopped = false;
            }
        }
    }
    void death()
    {
        GetComponent<NavMeshAgent>().isStopped = true;
        ifDead = true;
         Instantiate(explosion,transform.position,transform.rotation);
  
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            target.GetComponent<Health>().takeDamage(5);
            death();
        }
    }


}
