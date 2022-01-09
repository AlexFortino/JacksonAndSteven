using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemont : MonoBehaviour
{
    public float speed = 5;
    float horizontil = 0;
    float vericle = 0;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        horizontil += Input.GetAxis("Mouse X");
        vericle -= Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(0, horizontil, 0);
        cam.transform.eulerAngles = new Vector3(vericle, horizontil, 0);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back* speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
