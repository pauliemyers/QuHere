using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using VRStandardAssets.Utils;

[RequireComponent(typeof(VRInteractiveItem))]
public class VREventHandler : MonoBehaviour {

	private VRInteractiveItem vrInteractiveItem;
	public UnityEvent GazeEnterEvent;
	public UnityEvent GazeExitEvent;
	public UnityEvent ClickEvent;

	// Use this for initialization
	void Start () {
		vrInteractiveItem = GetComponent<VRInteractiveItem> ();
		vrInteractiveItem.OnOver += OnGazeEnter;
		vrInteractiveItem.OnOut += OnGazeExit;
		vrInteractiveItem.OnClick += OnClick;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGazeEnter() {
		GazeEnterEvent.Invoke ();
	}

	void OnGazeExit() {
		GazeExitEvent.Invoke ();
	}

	void OnClick() {
		ClickEvent.Invoke ();
	}
}


//Look up how to get phone debugging
//figure out adb
