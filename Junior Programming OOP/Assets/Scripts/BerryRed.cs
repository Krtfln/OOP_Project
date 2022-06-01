using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryRed : Berries
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnTriggerEnter(Collider other)
    {
        Debug.Log("Child Triggered");
        base.OnTriggerEnter(other);
    }
}
