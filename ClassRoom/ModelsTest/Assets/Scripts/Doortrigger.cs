using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
	private Door _door;
	// Use this for initialization
	void Start ()
	{
		_door=GameObject.Find("door").GetComponent<Door>(); //找到door对象模型的Door脚本组件
	}
	
	// Update is called once per frame
	void Update () { 
	
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("enter");
		if (other.gameObject.name=="Student")
		{
			//open
			_door.OpenDoor();
		}
	}

	private void OnTriggerExit(Collider other)
	{Debug.Log("leave");
		if (other.gameObject.name=="Student")
		{
			//close
			_door.CloseDoor();
		}
	}
}
  