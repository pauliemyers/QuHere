using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLifespan : MonoBehaviour {

	public bool canLive;

	// Use this for initialization
	void Start () {
		canLive = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void BeingLookedAt() {
		canLive = true;
	}

	public void LookedAway() {
		canLive = false;
	}
}
