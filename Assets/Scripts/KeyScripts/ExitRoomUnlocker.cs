using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitRoomUnlocker : MonoBehaviour
{
    [SerializeField] GameObject Door;

    public void Update()
    {
        if (KeyCollection.keysCollected == 9)
            Destroy(Door);
    }
}

