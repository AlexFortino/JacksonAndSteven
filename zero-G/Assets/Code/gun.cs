using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gun : MonoBehaviour
{
    GameObject ammoBar;
   

    public int MaxAmmo = 20;
    public int Ammo = 20;
    public bool Reloading = false;
   public  GameObject Bullet;
    public GameObject muzzle;

    //  Start is called before the first frame update
    void Start()
   
    {
        ammoBar = GameObject.FindGameObjectWithTag("Ammo UI");
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)&&Ammo>0)

        {
            Instantiate(Bullet, muzzle.transform.position, muzzle.transform.rotation);
            Ammo -= 1;
            ammoBar.GetComponent<Text>().text = Ammo.ToString();
            if (Ammo == 0)
            {
                Invoke("IsReloading", 3);
            }
        }
        if (Input.GetMouseButtonDown(0)&&Ammo > 0)

        {
            Instantiate(Bullet, muzzle.transform.position, muzzle.transform.rotation);
            Ammo -= 1;
            ammoBar.GetComponent<Text>().text = Ammo.ToString();
            if (Ammo == 0)
            {
                Invoke("IsReloading", 3);
            }
        }
    }

    void IsReloading()
    {
        Reloading = false;
        Ammo = MaxAmmo;

        ammoBar.GetComponent<Text>().text = Ammo.ToString();

    }

}
