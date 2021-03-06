using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

//	public float speed = 10.0f;
//
//	// Use this for initialization
//	void Start () 
//	{
//		Cursor.lockState = CursorLockMode.Locked;
//		//Turns off the cursor so you can't see it on screen, also keeps it in
//		//Game Window. But this prevents you from exiting via mouse.
//	}
//
//	// Update is called once per frame
//	void Update () {
//		float translation = Input.GetAxis ("Vertical") * speed;
//		float straffe = Input.GetAxis ("Horizontal") * speed;
//		//GetAxis and the strings are controlled internally in Unity --
//		//Specifically in Edit > Project Keys > Input
//		//Also: Fire 1 is LEFT MOUSE BUTTON
//		//ALSO: Mouse movement exists. We will use this later
//
//		translation *= Time.deltaTime;
//		straffe *= Time.deltaTime;
//
//		transform.Translate (straffe, 0.0f, translation);
//
//		if (Input.GetKeyDown("escape")) 
//		//press escape:
//		{
//			Cursor.lockState = CursorLockMode.None;
//			//Mouse returns
//		}
//	}
//}
	public float speed = 2f;
	public float sensitivity = 2f;
	CharacterController player;

	public GameObject eyes;

	float moveFB = 0;
	float moveLR = 0;

	float rotX;
	float rotY;

	public Vector3 currLocation, loc1, loc2, loc3, loc4;
	public bool shouldMove1, shouldMove2, shouldMove3, shouldMove4;

	void Start()
	{
		player = GetComponent<CharacterController>();
		currLocation = transform.position;
		shouldMove1 = false;
		shouldMove2 = false;
		shouldMove3 = false;
		shouldMove4 = false;
		loc1 = new Vector3 (-150f, 60f, 105f);
		loc2 = new Vector3 (100f, 60f, 125f);
		loc3 = new Vector3 (180f, 60f, -120f);
		loc4 = new Vector3 (-130f, 60f, -100f);

	}

	void Update() 
	{
		//moveFB = Input.GetAxis("Vertical") * speed;
		//moveLR = Input.GetAxis("Horizontal") * speed;

		currLocation = transform.position;

		rotX = Input.GetAxis("Mouse X") * sensitivity;
		rotY = Input.GetAxis("Mouse Y") * sensitivity;

		Vector3 movement = new Vector3(moveLR, 0, moveFB);
		transform.Rotate(0, rotX, 0);
		eyes.transform.Rotate(-rotY, 0, 0);

		movement = transform.rotation * movement;
		player.Move (movement * Time.deltaTime);

		if (shouldMove1)
		{
			currLocation = loc1;
			transform.position = currLocation;
			shouldMove1 = false;
		}

		if (shouldMove2)
		{
			currLocation = loc2;
			transform.position = currLocation;
			shouldMove2 = false;
		}

		if (shouldMove3)
		{
			currLocation = loc3;
			transform.position = currLocation;
			shouldMove3 = false;
		}

		if (shouldMove4)
		{
			currLocation = loc4;
			transform.position = currLocation;
			shouldMove4 = false;
		}

	}
}