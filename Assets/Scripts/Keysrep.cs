using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keysrep : MonoBehaviour
{
    public AudioSource collectionSound;

    void OnTriggerEnter(Collider other)  
    {
        collectionSound.Play();
        KeyCollection.keysCollected += 1;
        Destroy(gameObject);

    }
}

