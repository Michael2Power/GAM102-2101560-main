using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

 

public class NarrativeCornerStones : MonoBehaviour
{
	public KeyCollection ReferencedScript;
	private bool FirstKeySaid = false;
	public GameObject mazeEntrance;

   public void Update()
   {
	   if(KeyCollection.keysCollected == 1 && FirstKeySaid == false)
	   { 
		   Fungus.Flowchart.BroadcastFungusMessage("First Key");
		   FirstKeySaid = true;
	   }

   }
}
