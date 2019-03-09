using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Transform _transform;

    // Use this for initialization
    void Start()
    {
        _transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
//        if (Input.GetKeyDown(KeyCode.Z))
//        {
////			open
//            OpenDoor();
//        }
//
//        if (Input.GetKeyUp(KeyCode.Z))
//        {
////		close
//            CloseDoor();
//        }
    }

    public void OpenDoor()
    {
        _transform.Rotate(Vector3.up, 90);
    }

    public void CloseDoor()
    {
        _transform.Rotate(Vector3.up, -90);
    }
}