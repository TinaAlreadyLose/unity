 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioncube : MonoBehaviour {
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
