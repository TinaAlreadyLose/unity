using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ridibody : MonoBehaviour
{
	private Rigidbody _rigidbody;

	private Transform _transform;
	// Use this for initialization
	void Start () {
		_rigidbody=gameObject.GetComponent<Rigidbody>();
		_transform = gameObject.GetComponent<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			_rigidbody.MovePosition(_transform.position+Vector3.forward*0.1f);
		}if (Input.GetKey(KeyCode.A))
		{
			_rigidbody.MovePosition(_transform.position+Vector3.left*0.1f);
		}if (Input.GetKey(KeyCode.S))
		{
			_rigidbody.MovePosition(_transform.position+Vector3.back*0.1f);
		}if (Input.GetKey(KeyCode.D))
		{
			_rigidbody.MovePosition(_transform.position+Vector3.right*0.1f);
		}
		
	}
	
}
