using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 5f;
	public Rigidbody2D follower;

	private Rigidbody2D body;
	private Vector2 direction;

	void Start() {
		body = GetComponent<Rigidbody2D>();
	}

	void Update() {
		direction.x = Input.GetAxisRaw("Horizontal");
		direction.y = Input.GetAxisRaw("Vertical");

		direction.Normalize();
	}

	void FixedUpdate() {
		body.MovePosition(body.position + direction * speed * Time.fixedDeltaTime);

		follower.transform.position = new Vector3(body.position.x, body.position.y, follower.transform.position.z);
	}

}
