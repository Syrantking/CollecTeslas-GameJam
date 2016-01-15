using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	Vector3 move;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			move = Vector3.up;
		} else if (Input.GetKeyUp (KeyCode.DownArrow)) {
			move = Vector3.down;
		} else if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			move = Vector3.left;
		} else if (Input.GetKeyUp (KeyCode.RightArrow)) {
			move = Vector3.right;
		}
		*/

		move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	}
}
