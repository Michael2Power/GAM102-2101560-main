using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class EndGame : MonoBehaviour
{
    public KeyCollection ReferencedScript;

    public void Update()
    {
        if(KeyCollection.keysCollected == 10)
        {
           Fungus.Flowchart.BroadcastFungusMessage("Bye");
        }

          if (Input.GetKeyDown("r"))
        {
            Cursor.lockState -= CursorLockMode.Locked;
            SceneManager.LoadScene("StartScreen");
        }
       
    }

    public void Goodbye()
    {
          Cursor.lockState -= CursorLockMode.Locked;

            SceneManager.LoadScene("Endgame");

            KeyCollection.keysCollected = 0;
    }
}
