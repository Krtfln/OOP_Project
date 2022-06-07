using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    private GameObject prevSelectedBush; 
    [SerializeField] Material dafaultMaterial;
    [SerializeField] Material selectedMaterial;

    public void SelectBush(GameObject selectedBush)
    {
        if (prevSelectedBush == null)
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
