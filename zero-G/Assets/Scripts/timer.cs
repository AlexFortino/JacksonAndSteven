using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerActive = true;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                displayTime(timeRemaining);
            }
            else
            {
                Debug.Log("time has run out");
                timerActive = false;
            }
        }
    }
    void displayTime (float timeToshow)
    {
        timeToshow += 1;
        float minutes = Mathf.FloorToInt(timeToshow / 60);
        float seconds = Mathf.FloorToInt(timeToshow % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
