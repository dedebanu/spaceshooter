using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	float moveHorizontal;
	public Rigidbody player;
	public float xmin,xmax,speed,tilt;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float nextFire;
	//public audio a;
	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody> ();
		//a = GetComponent<audio> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			//a.Play ();
			GetComponent<AudioSource>().Play();
		}
	}
		
	void FixedUpdate()
	{
		moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 v = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		player.velocity= (v*speed);
		//player.position = new Vector3 (Mathf.Clamp(player.position.x,xmin,xmax),0.0f,0.0f);
		player.rotation=Quaternion.Euler(0.0f,0.0f,player.velocity.x*tilt);
	}
}
