using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidrotete : MonoBehaviour {
	public float tumble;
	public Rigidbody astroid;
	// Use this for initialization
	void Start () {
		astroid.angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
