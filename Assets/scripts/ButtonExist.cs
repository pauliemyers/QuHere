using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExist : MonoBehaviour {

	private bool wasLooked;
	public bool buttonsHere;
	private GameObject button01;
	private GameObject button02;

	// Use this for initialization
	void Start () {
		wasLooked = gameObject.GetComponent<ButtonCreator>().wasLookedAt;
		buttonsHere = false;
		button01 = gameObject.transform.GetChild(0).gameObject;
		button02 = gameObject.transform.GetChild(1).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		wasLooked = gameObject.GetComponent<ButtonCreator>().wasLookedAt;
	}

	public void Appear() 
	{
		if (wasLooked && !buttonsHere) 
		{
			button01.GetComponent<Renderer>().enabled = true;
			button01.GetComponent<Collider>().enabled = true;
			button02.GetComponent<Renderer>().enabled = true;
			button02.GetComponent<Collider>().enabled = true;
			buttonsHere = true;
		}
	}
}
