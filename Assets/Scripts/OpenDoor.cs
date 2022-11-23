using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public KeyCollection ReferencedScript;
    [SerializeField] GameObject KeyBlock;

    public void Update()
    {
        if (KeyCollection.keysCollected == 8)
            Destroy(KeyBlock);
    }
}
