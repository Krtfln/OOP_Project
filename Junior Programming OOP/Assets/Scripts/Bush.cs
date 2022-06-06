using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    private float timeToGrow;
    private float speed;
    private int pointsToAdd;
    private bool berryIsReady = true;
    private string speedText;
    private GameManager gameManager;
    private PlayerController playerController;

    public Bush(float timeToGrow, int pointsToAdd, float speed, string speedText)
    {
        this.timeToGrow = timeToGrow;
        this.pointsToAdd = pointsToAdd;
        this.speed = speed;
        this.speedText = speedText;
    }

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public void OnTriggerStay(Collider other)
    {
        if (gameObject == playerController.hit.collider.gameObject && berryIsReady && gameManager.gameIsActive)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            berryIsReady = false;
            gameManager.AddPoints(pointsToAdd);
            gameManager.ShowInfoText(pointsToAdd, speedText);
            Invoke("BerryGrow", timeToGrow);
            playerController.ChangeSpeed(speed);
        }
    }

    void BerryGrow()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        berryIsReady = true;
    }
}
