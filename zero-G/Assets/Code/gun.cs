using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
   public  GameObject Bullet;
    public GameObject muzzle;

    //  Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))

        {
            Instantiate(Bullet, muzzle.transform.position, muzzle.transform.rotation);

}
        if (Input.GetMouseButtonDown(0))

        {
            Instantiate(Bullet, muzzle.transform.position, muzzle.transform.rotation);

        }
    }

}
