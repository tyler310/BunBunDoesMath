using UnityEngine;
using System.Collections;

public class two : MonoBehaviour {
	public float speed = 2;
	
	void Start() {
		// Initial Velocity
		GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * speed;
	}
}