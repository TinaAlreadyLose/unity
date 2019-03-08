using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class student : MonoBehaviour
{
	private Transform m_Transform;
	// Use this for initialization
	void Start () {
		m_Transform=gameObject.GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {
//		m_Transform.Translate(Vector3.forward * 0.1f /*向前*/, Space.Self /*以自身为坐标系*/);
		if (Input.GetKey(KeyCode.W))
		{
			m_Transform.Translate(Vector3.forward * 0.1f /*向前*/, Space.Self /*以自身为坐标系*/);
		}if (Input.GetKey(KeyCode.S))
		{
			m_Transform.Translate(Vector3.back * 0.1f /*向前*/, Space.Self /*以自身为坐标系*/);
		}if (Input.GetKey(KeyCode.A))
		{
			m_Transform.Translate(Vector3.left * 0.1f /*向前*/, Space.Self /*以自身为坐标系*/);
		}if (Input.GetKey(KeyCode.D))
		{
			m_Transform.Translate(Vector3.right * 0.1f /*向前*/, Space.Self /*以自身为坐标系*/);
		}
	}
}
