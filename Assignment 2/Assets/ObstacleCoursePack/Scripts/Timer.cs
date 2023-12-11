using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // declare this to use UI elements

public class Timer : MonoBehaviour
{
    public float timeRemaining = 120;
    public bool timerIsRunning = false;
    public Text timerText; // declare this to use UI elements


    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true; // this bool will start the timer
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
            // this will count down the timer
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time is up!");
                timeRemaining = 0;
                timerIsRunning = false; // change bool to false, so timer stops
            }
        }

        timerText.text = timeRemaining.ToString("0"); // set the time remaining float to a string of characters

    }
}
