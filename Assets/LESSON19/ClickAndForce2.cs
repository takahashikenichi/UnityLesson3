using UnityEngine;
using System.Collections;

public class ClickAndForce2 : MonoBehaviour {
	
	public Vector3 force;
	public ForceMode mode = ForceMode.Force;
	
	void Update () {
		if (Input.GetMouseButtonUp(0)) {
			rigidbody.AddForce(force, mode);
		}
	}
}
