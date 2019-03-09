using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggercube : MonoBehaviour {

	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("cube enter"+other.gameObject.name);
	}

	private void OnTriggerStay(Collider other)
	{
		Debug.Log("cube stay"+other.gameObject.name);
	}

	private void OnTriggerExit(Collider other)
	{
		Debug.Log("cube exit"+other.gameObject.name);
	}	
}
