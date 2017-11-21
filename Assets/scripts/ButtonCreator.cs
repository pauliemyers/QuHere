using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreator : MonoBehaviour {

	private Renderer buttonRender01;
	private Renderer buttonRender02;
	private Collider buttonCollide01;
	private Collider buttonCollide02;

	public bool wasLookedAt;

	// Use this for initialization
	void Start () {
		buttonRender01 = gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer> ();
		buttonRender01.enabled = false;
		buttonRender02 = gameObject.transform.GetChild(1).gameObject.GetComponent<Renderer> ();
		buttonRender02.enabled = false;

		buttonCollide01 = gameObject.transform.GetChild(0).gameObject.GetComponent<Collider> ();
		buttonCollide01.enabled = false;
		buttonCollide02 = gameObject.transform.GetChild(1).gameObject.GetComponent<Collider> ();
		buttonCollide02.enabled = false;

		wasLookedAt = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ButtonAllow() {
		wasLookedAt = true;
	}

	public void NoButtonAllow() {
		wasLookedAt = false;
	}
}
