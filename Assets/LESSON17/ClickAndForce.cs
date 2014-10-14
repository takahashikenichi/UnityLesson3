using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class ClickAndForce : MonoBehaviour {
	
	public Vector3 force;
	public ForceMode mode = ForceMode.Force;
	
	void Update () {
		// left click
		if (Input.GetMouseButton(0)) {
			rigidbody.AddForce(force, mode);
		}
		// right click
		if (Input.GetMouseButtonUp(1)) {
			rigidbody.AddForce(force, mode);
		}
	}
}
