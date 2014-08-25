using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {



	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;

	void Update () {

		if (target) {

			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);


			// this section exists because C# won't let me change the attribute directly I guess
			Vector3 temp = transform.position; // copy to temp var
			temp.y = 1.0f; // modify the attribute in the temporary var
			transform.position = temp; // and save the changed attribute \_(-____-)_/

			
		}
	}
}

 