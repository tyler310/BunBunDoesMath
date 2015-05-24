using UnityEngine;
using System.Collections;

public class HatScript : MonoBehaviour {
    public float speed = 30;
    public string axis = "Horizontal";
	
	// Update is called once per frame
	void FixedUpdate () {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(v,0) * speed;
	}
}
