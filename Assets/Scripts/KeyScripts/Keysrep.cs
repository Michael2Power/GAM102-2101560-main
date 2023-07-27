using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keysrep : MonoBehaviour
{

    void OnTriggerEnter(Collider other)  
    {
       
        KeyCollection.keysCollected += 1;
        Destroy(gameObject);

    }
}

