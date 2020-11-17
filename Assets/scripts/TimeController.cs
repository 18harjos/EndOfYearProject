using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public static TimeController timeController;
    public VictoryMenu victoryScreen;
    public Text timeCounter;

    public int enemyCounter;
    
    private TimeSpan timePlaying;
    private static bool timerGoing;

    private float elapsedTime;

    
    //Initiating the time controller
    private void Awake()
    {
        timeController = this;
    }

    // setting the time to 0 and setting the ammount of enemys in game
    public void Start()
    {
        timeCounter.text = "Time: 00:00.00";
        timerGoing = false;

        victoryScreen = FindObjectOfType<VictoryMenu>();
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCounter = enemy.Length;

        

        BeginTimer();
    }

    public void ReduceEnemyCounter()//decreasing the ammount of enemys left in the level
    {
        print("before "+ enemyCounter);
        enemyCounter--;
        print("after " + enemyCounter);
    }
    public void BeginTimer() //Beggining the timer
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()//stopping the timer
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)//increasing the timer every second
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;

            
            yield return null;
            
        }
    }
    public void Update()// ending the game if there are no more enemys left
    {
        if (enemyCounter == 0)
        {
            victoryScreen.victory();
            EndTimer();

        }


    }
    // Update is called once per frame
}
