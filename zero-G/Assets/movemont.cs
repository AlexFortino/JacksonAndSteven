using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class movemont : MonoBehaviour
{

    Vector2 dir;
    public float speed = 5;
    float horizontil = 0;
    float vericle = 0;
    Camera cam;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontil += Input.GetAxis("Mouse X");
        vericle -= Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(vericle, horizontil, 0);
        cam.transform.eulerAngles = new Vector3(vericle, horizontil, 0);

        dir = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            rb.AddRelativeForce(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
            rb.AddRelativeForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.back* speed * Time.deltaTime);
            rb.AddRelativeForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * speed * Time.deltaTime);
            rb.AddRelativeForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
            rb.AddRelativeForce(Vector3.up);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //transform.Translate(Vector3.back* speed * Time.deltaTime);
            rb.AddRelativeForce(Vector3.down);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
            rb.AddRelativeTorque(-Vector3.forward*2);
        }
        if (Input.GetKey(KeyCode.E))
        {
            //transform.Translate(Vector3.back* speed * Time.deltaTime);
            rb.AddRelativeTorque(Vector3.forward*2);
        }
    }
} 
