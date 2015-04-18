using UnityEngine;
using System.Collections;

public class AI1 : MonoBehaviour {

	private Vector3 Player;
	private Vector2 Playerdirection;
	private float Xdif;
	private float Ydif;
	public float speed;
	private int wall;
   
	void Update () {

		Player = GameObject.Find ("Player").transform.position;
		Xdif = Player.x - transform.position .x;
		Ydif = Player.y - transform.position.y;

		Playerdirection = new Vector2 (Xdif, Ydif);
		//if(Physics2D.Raycast(transform.position, Playerdirection ))
		GetComponent<Rigidbody2D>().AddForce (Playerdirection.normalized * speed);
		Debug.Log (Playerdirection);

	}
}
