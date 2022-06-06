using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    private float timeToGrow;
    private float speedMultiplier;
    private int pointsToAdd;
    private bool berryIsReady = true;
    private GameManager gameManager;
    private PlayerController playerController;
    
    public Bush(float timeToGrow, int pointsToAdd, float speedMultiplier)
    {
        this.timeToGrow = timeToGrow;
        this.pointsToAdd = pointsToAdd;
        this.speedMultiplier = speedMultiplier;
    }

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public void OnTriggerStay(Collider other)
    {
        if (gameObject == playerController.hit.collider.gameObject && berryIsReady)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            berryIsReady = false;
            gameManager.AddPoints(pointsToAdd);
            Invoke("BerryGrow", timeToGrow);
            playerController.ChangeSpeed(speedMultiplier);
        }
    }

    void BerryGrow()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        berryIsReady = true;
    }
}
