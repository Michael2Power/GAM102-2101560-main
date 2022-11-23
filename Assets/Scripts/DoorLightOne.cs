using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLightOne : MonoBehaviour
{
    [SerializeField] GameObject DoorLight1;
    [SerializeField] GameObject DoorLight2;
    [SerializeField] GameObject DoorLight3;
    [SerializeField] GameObject DoorLight4;


    public void Update()
    {
        if (KeyCollection.keysCollected == 5)
            DoorLight1.GetComponent<Renderer>().material.color = new Color(0, 255, 0);

        if (KeyCollection.keysCollected == 6)
            DoorLight2.GetComponent<Renderer>().material.color = new Color(0, 255, 0);

        if (KeyCollection.keysCollected == 7)
            DoorLight3.GetComponent<Renderer>().material.color = new Color(0, 255, 0);

        if (KeyCollection.keysCollected == 8)
            DoorLight4.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
    }
}
