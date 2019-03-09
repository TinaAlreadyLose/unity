using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTrigger : MonoBehaviour {
	private GameObject[] _gameObjects;
	
	// Use this for initialization
	void Start () {
		_gameObjects=GameObject.FindGameObjectsWithTag("Desks");
//		for (int i = 0; i < _gameObjects.Length; i++)
//		{
//			Debug.Log(_gameObjects[i].name);
//		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z))
		{
			//up
			DeskUP();
		}

		if (Input.GetKeyUp(KeyCode.Z))
		{
			//down
			DeskDOWN();
		}
	}

	void DeskUP()
	{
		for (int i = 0; i < _gameObjects.Length; i++)
		{
			_gameObjects[i].GetComponent<Transform>().Translate(Vector3.up*2,Space.Self);
		}
	}

	void DeskDOWN()
	{
		for (int i = 0; i < _gameObjects.Length; i++)
		{
			_gameObjects[i].GetComponent<Transform>().Translate(Vector3.down*2,Space.Self);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name=="Student")
		{
			DeskUP();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name=="Student")
		{
			DeskDOWN();
		}
	}
}
