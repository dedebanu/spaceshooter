using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
	public Rigidbody b;
	public float speed;
	// Use this for initialization
	void Start () {
		b = GetComponent<Rigidbody> ();
		b.velocity = new Vector3(0.0f,0.0f,1.0f) * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
