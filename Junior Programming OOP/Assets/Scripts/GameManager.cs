using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int points;
    [SerializeField] private TMP_Text pointsText;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private TMP_Text victoryText;
    private float time = 30f;
    public bool gameIsActive = true;

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
        if(time > 0)
        {
            if(time < 11)
                timerText.color = Color.red;
            time--;
            timerText.text = "Time: " + time;
        }
        if(time <= 0)
        {
            timerText.text = "Time: " + time;
            GameOver();
        }
    }

    void GameOver()
    {
        gameIsActive = false;
        if(points >= 50)
            victoryText.gameObject.SetActive(true);
        else
            gameOverText.gameObject.SetActive(true);
    }
}
