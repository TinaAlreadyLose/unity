using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
			Debug.Log("getA");
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("k down");
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			Debug.Log("key up");
		}
// 0-左键1-右键 2-中建
		if (Input.GetMouseButton(0))
		{
			Debug.Log("左键");
		}

		if (Input.GetMouseButtonUp(0))
		{
			Debug.Log("左键uo");
		}
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("左键down");
		}
	}
}
