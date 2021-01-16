using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission1 : MonoBehaviour {

	private const int CORRECT_SOLUTION = 3;

	private Rigidbody2D body;

	void Start() {
		body = GetComponent<Rigidbody2D>();
	}

	public void clickSolution(int solution) {
		Debug.Log(solution);

		if (solution == CORRECT_SOLUTION) {
			MissionTrigger.succeeded = true;
			body.transform.position = new Vector3(body.transform.position.x, body.transform.position.y, 10000);
		} else {
			// TODO
		}
	}

}
