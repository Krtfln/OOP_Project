using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    private float timeToGrow;
    private int pointsToAdd;
    private float speedMultiplier;
    private GameManager gameManager;

    public Bush(float timeToGrow, int pointsToAdd)
    {
        this.timeToGrow = timeToGrow;
        this.pointsToAdd = pointsToAdd; 
    }

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        transform.GetChild(0).gameObject.SetActive(false);
        gameManager.AddPoints(pointsToAdd);
        StartCoroutine(BerryReady());
    }

    IEnumerator BerryReady()
    {
        yield return new WaitForSeconds(timeToGrow);
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
