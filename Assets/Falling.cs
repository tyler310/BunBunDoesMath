using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public float speed = 2;
	
	void Start() {
		// Initial Velocity
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
}