using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FinalTut : MonoBehaviour
{
 public GameObject player;
 public GameObject Self;
public Flowchart Flowchart;

   void OnTriggerEnter(Collider player)
   {
	   Debug.Log("working2");
	   Fungus.Flowchart.BroadcastFungusMessage("F");
	   Destroy(Self);
   }
}

