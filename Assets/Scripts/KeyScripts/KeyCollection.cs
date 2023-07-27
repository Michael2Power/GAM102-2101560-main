using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyCollection : MonoBehaviour
{
    public static int keysCollected = 0;
    public TextMeshProUGUI textDisplay;

    void Start ()
    {
        textDisplay.text = "Keys Collected :" + KeyCollection.keysCollected;
    }


    void Update ()
    {
        textDisplay.text = "Keys Collected : " + KeyCollection.keysCollected;
    }

   
}
