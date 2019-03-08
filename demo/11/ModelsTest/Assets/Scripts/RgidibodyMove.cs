using UnityEngine;
using System.Collections;

public class RgidibodyMove : MonoBehaviour {

	private Rigidbody m_Rigidboby;
	private Transform m_Transform;

	void Start () {
		m_Rigidboby = gameObject.GetComponent<Rigidbody> ();
		m_Transform = gameObject.GetComponent<Transform> ();
	}

	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			m_Rigidboby.MovePosition (m_Transform.position + Vector3.forward * 0.2f);
		}

		if(Input.GetKey(KeyCode.S))
		{	
			m_Rigidboby.MovePosition (m_Transform.position + Vector3.back * 0.2f);
		}

		if(Input.GetKey(KeyCode.A))
		{
			m_Rigidboby.MovePosition (m_Transform.position + Vector3.left * 0.2f);
		}

		if(Input.GetKey(KeyCode.D))
		{
			m_Rigidboby.MovePosition (m_Transform.position + Vector3.right * 0.2f);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name != "Ground")
		{
			Debug.Log("enter"+other.gameObject.name);
		}
	}

	private void OnCollisionExit(Collision other)
	{
		if (other.gameObject.name != "Ground")
		{
			Debug.Log("exit"+other.gameObject.name);
		} 

	}
	private void OnCollisionStay(Collision other)
	{
		if (other.gameObject.name != "Ground")
		{
			Debug.Log("stay"+other.gameObject.name);
		}
	}
}
