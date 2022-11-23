using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeDoorOpen : MonoBehaviour
{
    public KeyCollection ReferencedScript;
    [SerializeField] GameObject KeyBlock;

    public void Update()
    {
        if (KeyCollection.keysCollected == 4)
            Destroy(KeyBlock);
    }
}
