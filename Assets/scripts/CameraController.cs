using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	Vector2 mouseLook;
	//how much movement the camera has made... but only CHANGE since last update
	Vector2 smoothV;
	//smoothing - not necessary!
	public float sensitivity = 5.0f;
	//tells you how much movement you need
	public float smoothing = 2.0f;

	GameObject character;

	// Use this for initialization
	void Start () {

		character = this.transform.parent.gameObject;
		//this saves the parent of the camera as the player

	}

	// Update is called once per frame
	void Update () {
		var md = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));
		//movement delta
		smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
		//linear interpretation of movement: moves more smoothly between two points
		//Lerp is used a lot to move things between two places smoothly - I will learn this
		//begin point, end-point, and where to go
		smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);

		mouseLook += smoothV;
		mouseLook.y = Mathf.Clamp (mouseLook.y, -90f, 90f);

		transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right);
		//right axis is the x axis... which is an up-down rotation. Move this by moving mouse in Y direction
		//Inverted system! Which means mouse forward makes head go down.
		character.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, character.transform.up);
		//mouse look x rotates around character's "up", not camera, because we want the whole
		//character to move.

	}
}