﻿using UnityEngine;
using System.Collections;

public class four : MonoBehaviour {
	public float speed = 2;
    public int value = 4;

	void Start() {
		// Initial Velocity
		GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * speed;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Hat")
        {
            ScoreScript.score += value;
            Destroy(gameObject);
        }
    }
}