using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTrigger : MonoBehaviour {

	public static int counter = 0;
	public static bool succeeded = false;

	public Rigidbody2D mission1;
	public Rigidbody2D mission2;

	private int accomplished = -1;

	void Start() {
		mission1.transform.position = new Vector3(mission1.transform.position.x, mission1.transform.position.y, 10000);
		mission2.transform.position = new Vector3(mission2.transform.position.x, mission1.transform.position.y, 10000);
	}

	void Update() {
		if (Input.GetAxisRaw("Cancel") != 0) {
			mission1.transform.position = new Vector3(mission1.transform.position.x, mission1.transform.position.y, 10000);
			mission2.transform.position = new Vector3(mission2.transform.position.x, mission1.transform.position.y, 10000);
			succeeded = true;
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.name == "player" && accomplished == -1) {
			accomplished = counter;
			succeeded = false;

			switch(counter) {
			case 0:
				mission2.transform.position = new Vector3(mission2.transform.position.x, mission1.transform.position.y, 10000);
				mission1.transform.position = new Vector3(mission1.transform.position.x, mission1.transform.position.y, -50);
				break;

			case 1:
				mission1.transform.position = new Vector3(mission1.transform.position.x, mission1.transform.position.y, 10000);
				mission2.transform.position = new Vector3(mission2.transform.position.x, mission1.transform.position.y, -50);
				break;
			}
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if (col.gameObject.name == "player") {
			mission1.transform.position = new Vector3(mission1.transform.position.x, mission1.transform.position.y, 10000);
			mission2.transform.position = new Vector3(mission2.transform.position.x, mission1.transform.position.y, 10000);

			if (succeeded)
				counter = (counter + 1) % 2;
			else accomplished = -1;
		}
	}

}
