using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    GameObject healthBar;
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GameObject.FindGameObjectWithTag("Health UI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takeDamage(int dmg)
    {
        health = health - dmg;
        healthBar.GetComponent<Text>().text=health.ToString();
        if (health <= 0)
        {
            Debug.Log("you are dead");
        }
    }
}
