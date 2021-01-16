using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

	private Rigidbody2D body;

	void Start() {
		body = GetComponent<Rigidbody2D>();

		body.transform.position = new Vector3(body.transform.position.x, body.transform.position.y, 10000);
	}

	void Update() {
		if (Input.GetAxisRaw("Submit") != 0)
			body.transform.position = new Vector3(body.transform.position.x, body.transform.position.y, -80);
	}

}
