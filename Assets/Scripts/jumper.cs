using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour {
	public Rigidbody playerBody1;
	public float speedMultiplier1;

	Vector3 deltaPos;

	void Start () {
		deltaPos = Vector3.zero;
		
	}
	void Update() {
		deltaPos.y = Input.GetAxis ("Jump");
		

	}
	void FixedUpdate()
	{
		playerBody1.AddForce(deltaPos * speedMultiplier1);
	}
}