using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public float rotateSpeed = 0.2F;

	void Update() {

		if (Input.GetKey (KeyCode.A)) {
			transform.position += transform.right * -1 * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.position += transform.right * 1 * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * 1 * speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position += transform.forward * -1 * speed * Time.deltaTime;
		}
		
		if (Input.GetKey (KeyCode.Q)) {
			transform.Rotate (Vector3.down, rotateSpeed);
		}

		if (Input.GetKey(KeyCode.E)) {
			transform.Rotate(Vector3.up, rotateSpeed);
		}
	}
}
