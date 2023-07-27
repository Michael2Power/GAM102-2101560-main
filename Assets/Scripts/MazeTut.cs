using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MazeTut : MonoBehaviour
{
public GameObject player;
public GameObject Me;
public Flowchart Flowchart;

   void OnTriggerEnter(Collider player)
   {
	   Debug.Log("working");
	   Fungus.Flowchart.BroadcastFungusMessage("E");

	   Destroy(Me);
   }
}
