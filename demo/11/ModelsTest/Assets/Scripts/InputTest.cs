using UnityEngine;
using System.Collections;

public class InputTest : MonoBehaviour {

	//1.
	void Start () {
		
	}
	
	//N次 1秒 60次.
	void Update () {
		//
		if(Input.GetKey(KeyCode.A))
		{
			Debug.Log ("GetKey:A...");	
		}

		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log ("GetKeyDown:A Down");
		}

		if (Input.GetKeyUp(KeyCode.A)) 
		{
			Debug.Log ("GetKeyUp: A Up");
		}

		//Mouse.
		if (Input.GetMouseButton (0)) 
		{
			Debug.Log ("Mouse Left ");
		}

		if (Input.GetMouseButtonDown (0)) 
		{
			Debug.Log ("MOuse Left Down");
		}
	
		if (Input.GetMouseButtonUp (0)) 
		{
			Debug.Log ("MOuse Left Up");
		}
	}
}
