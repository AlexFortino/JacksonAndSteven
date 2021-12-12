using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour

{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
          

    }

    // Update is called once per frame
    void Update()
    {


        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Instantiate(target);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            Instantiate(target,transform);
        }

    }
}
