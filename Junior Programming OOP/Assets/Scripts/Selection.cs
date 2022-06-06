using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    private GameObject prevSelectedBush; 
    [SerializeField] Material dafaultMaterial;
    [SerializeField] Material selectedMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectBush(GameObject selectedBush)
    {
        if(prevSelectedBush == null)
        {
            selectedBush.GetComponent<Renderer>().material = selectedMaterial;
            prevSelectedBush = selectedBush;
        }
        if (selectedBush != prevSelectedBush)
        {
            selectedBush.GetComponent<Renderer>().material = selectedMaterial;
            prevSelectedBush.GetComponent<Renderer>().material = dafaultMaterial;
            prevSelectedBush = selectedBush;
        }     
    }
}
