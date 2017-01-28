using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class destroybycomtact : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerexplosion;
	public int scorevalue;
	public GameController g;
	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			g = gameControllerObject.GetComponent<GameController> ();
		}
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "bound") {
			return;
		}
		Instantiate (explosion, transform.position, transform.rotation);
		//score = score + 10;

		if (other.tag == "Player") {
			Instantiate (playerexplosion, other.transform.position, other.transform.rotation);
			g.GameOver ();
		}
		g.Addscore (scorevalue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}

}
