using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceTest : MonoBehaviour
{
	private Rigidbody _rigibody;
	// Use this for initialization
	void Start () {
		_rigibody = gameObject.GetComponent<Rigidbody>();//获取定义组件的信息 
		
	}
	
	// Update is called once per frame
	void Update () {
//		_rigibody.AddForce(Vector3.forward,ForceMode.Acceleration);
		// _rigibody.AddRelativeForce(Vector3.forward*10,ForceMode.Force);//在范围内来回滚动
		 //解决方式,加入选择语句,通过按键前进
		 if (Input.GetKeyDown(KeyCode.Z))
		 {
			 _rigibody.AddRelativeForce(Vector3.forward*1000,ForceMode.Force);
		 }
	}

	private void FixedUpdate()
	{
		throw new System.NotImplementedException();
	}
}
