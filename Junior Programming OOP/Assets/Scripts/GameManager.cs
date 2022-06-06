using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] private TMP_Text pointsText;
    [SerializeField] private TMP_Text timerText;
    private float time = 30f;

    // Start is called before the first frame update
    void Start()
    {
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
        Debug.Log("Points" + points);
    }

    void Timer()
    {
        time--;
        timerText.text = "Time: " + time;
    }
}
