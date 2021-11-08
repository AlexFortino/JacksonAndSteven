using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 5f;
    public float speed = 10f;    
     
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime); 
    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy") {

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }


}
