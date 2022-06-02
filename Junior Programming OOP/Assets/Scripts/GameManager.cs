using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] private TMP_Text pointsText;
    [SerializeField] private TMP_Text timerText;
    private float time = 30f;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Timer());
        InvokeRepeating("Timer", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
        pointsText.text = "Points: " + points;
        Debug.Log(points);
    }

    //IEnumerator Timer()
    //{
    //    yield return new WaitForSeconds(1);
    //    time--;
    //    timerText.text = "Time: " + time;
    //}

    void Timer()
    {
        time--;
        timerText.text = "Time: " + time;
    }
}
