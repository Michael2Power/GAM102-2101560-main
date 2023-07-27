using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndgameTransfer : MonoBehaviour
{
  public KeyCollection ReferencedScript;

    void Update()
    {
        if(KeyCollection.keysCollected == 10)
        {
             Cursor.lockState -= CursorLockMode.Locked;

            SceneManager.LoadScene("Endgame");

            KeyCollection.keysCollected = 0;

        }

          if (Input.GetKeyDown("r"))
        {
            Cursor.lockState -= CursorLockMode.Locked;
            SceneManager.LoadScene("StartScreen");
        }
       
    }
}   
