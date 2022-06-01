using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berries : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetSpeedMultiplier()
    {
        return 1;
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        transform.GetChild(0).gameObject.SetActive(false);
        StartCoroutine(BerryReady());
    }

    IEnumerator BerryReady()
    {
        yield return new WaitForSeconds(5);
        transform.GetChild(0).gameObject.SetActive(true);
        
    }
}
