using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLightOne : MonoBehaviour
{
    [SerializeField] GameObject DoorLight1;
    public GameObject DoorLight1FX;
    [SerializeField] GameObject DoorLight2;
    public GameObject DoorLight2FX;
    [SerializeField] GameObject DoorLight3;
    public GameObject DoorLight3FX;
    [SerializeField] GameObject DoorLight4;
    public GameObject DoorLight4FX;


    public void Update()
    {
        if (KeyCollection.keysCollected == 5)
            DoorLight1.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
            DoorLight1FX.SetActive(true);

        if (KeyCollection.keysCollected == 6)
            DoorLight2.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
             DoorLight2FX.SetActive(true);

        if (KeyCollection.keysCollected == 7)
            DoorLight3.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
             DoorLight3FX.SetActive(true);

        if (KeyCollection.keysCollected == 8)
            DoorLight4.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
             DoorLight4FX.SetActive(true);
    }
}
