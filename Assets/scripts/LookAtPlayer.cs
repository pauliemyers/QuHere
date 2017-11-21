using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

	public GameObject thingToStareAt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var vectorBetweenUs = transform.position - thingToStareAt.transform.position;
		transform.forward = vectorBetweenUs.normalized;
	}
}
