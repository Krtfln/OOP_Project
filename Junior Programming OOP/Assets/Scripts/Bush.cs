using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    private float timeToGrow;
    private int pointsToAdd;
    private float speedMultiplier;
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

    public void OnTriggerEnter(Collider other)
    {
        if (gameObject == playerController.hit.collider.gameObject)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            gameManager.AddPoints(pointsToAdd);
            StartCoroutine(BerryReady());
            playerController.ChangeSpeed(speedMultiplier);
        }
    }

    IEnumerator BerryReady()
    {
        yield return new WaitForSeconds(timeToGrow);
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
