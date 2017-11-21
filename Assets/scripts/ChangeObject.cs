using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour {
	private GameObject[] listOfLights;
	private GameObject[] listOfTrees;
	private GameObject[] listOfTreasures;
	private GameObject[] listOfBeds;

	// Use this for initialization
	void Start () {
		listOfLights = GameObject.FindGameObjectsWithTag ("DecoLight");
		listOfTrees = GameObject.FindGameObjectsWithTag ("DecoTree");
		listOfTreasures = GameObject.FindGameObjectsWithTag ("DecoTreasure");
		listOfBeds = GameObject.FindGameObjectsWithTag ("DecoBed");
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ObjChanger() {

		if (gameObject.transform.parent.tag == "DecoLight")
		{
			foreach (GameObject thisLight in listOfLights) {
				if (thisLight.GetComponent<Collider> ().enabled && thisLight.GetComponent<Renderer> ().enabled) {
					thisLight.GetComponent<Renderer> ().enabled = false;
					thisLight.GetComponent<Collider> ().enabled = false;
					thisLight.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
					thisLight.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
					thisLight.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
					thisLight.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
					thisLight.GetComponent<ButtonExist> ().buttonsHere = false;
				} else {
					thisLight.GetComponent<Renderer> ().enabled = true;
					thisLight.GetComponent<Collider> ().enabled = true;
				}
				}
			foreach (GameObject thisTree in listOfTrees)
			{
				thisTree.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTree.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisTree.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTree.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisTree.GetComponent<ButtonExist> ().buttonsHere = false;
			}
			foreach (GameObject thisTreasure in listOfTreasures)
			{
				thisTreasure.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTreasure.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisTreasure.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTreasure.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisTreasure.GetComponent<ButtonExist> ().buttonsHere = false;
			}
			foreach (GameObject thisBed in listOfBeds)
			{
				thisBed.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisBed.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisBed.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisBed.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisBed.GetComponent<ButtonExist> ().buttonsHere = false;
			}
		}
		else if (gameObject.transform.parent.tag == "DecoTree")
		{
			foreach (GameObject thisTree in listOfTrees) {
				if (thisTree.GetComponent<Collider> ().enabled && thisTree.GetComponent<Renderer> ().enabled) {
					thisTree.GetComponent<Renderer> ().enabled = false;
					thisTree.GetComponent<Collider> ().enabled = false;
					thisTree.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
					thisTree.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
					thisTree.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
					thisTree.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
					thisTree.GetComponent<ButtonExist> ().buttonsHere = false;
				} else {
					thisTree.GetComponent<Renderer> ().enabled = true;
					thisTree.GetComponent<Collider> ().enabled = true;
				}
			}
			foreach (GameObject thisLight in listOfLights)
			{
				thisLight.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisLight.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisLight.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisLight.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisLight.GetComponent<ButtonExist> ().buttonsHere = false;
			}
			foreach (GameObject thisTreasure in listOfTreasures)
			{
				thisTreasure.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTreasure.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisTreasure.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTreasure.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisTreasure.GetComponent<ButtonExist> ().buttonsHere = false;
			}
			foreach (GameObject thisBed in listOfBeds)
			{
				thisBed.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisBed.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisBed.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisBed.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisBed.GetComponent<ButtonExist> ().buttonsHere = false;
			}
		}
		else if (gameObject.transform.parent.tag == "DecoTreasure")
		{
			foreach (GameObject thisTreasure in listOfTreasures) {
				if (thisTreasure.GetComponent<Collider> ().enabled && thisTreasure.GetComponent<Renderer> ().enabled) {
					thisTreasure.GetComponent<Renderer> ().enabled = false;
					thisTreasure.GetComponent<Collider> ().enabled = false;
					thisTreasure.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
					thisTreasure.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
					thisTreasure.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
					thisTreasure.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
					thisTreasure.GetComponent<ButtonExist> ().buttonsHere = false;
				} else {
					thisTreasure.GetComponent<Renderer> ().enabled = true;
					thisTreasure.GetComponent<Collider> ().enabled = true;
				}
			}
			foreach (GameObject thisLight in listOfLights)
			{
				thisLight.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisLight.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisLight.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisLight.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisLight.GetComponent<ButtonExist> ().buttonsHere = false;
			}
			foreach (GameObject thisTree in listOfTrees)
			{
				thisTree.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTree.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisTree.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTree.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisTree.GetComponent<ButtonExist> ().buttonsHere = false;
			}
			foreach (GameObject thisBed in listOfBeds)
			{
				thisBed.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisBed.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisBed.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisBed.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisBed.GetComponent<ButtonExist> ().buttonsHere = false;
			}
		}
		else if (gameObject.transform.parent.tag == "DecoBed")
		{
			foreach (GameObject thisBed in listOfBeds) {
				if (thisBed.GetComponent<Collider> ().enabled && thisBed.GetComponent<Renderer> ().enabled) {
					thisBed.GetComponent<Renderer> ().enabled = false;
					thisBed.GetComponent<Collider> ().enabled = false;
					thisBed.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
					thisBed.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
					thisBed.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
					thisBed.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
					thisBed.GetComponent<ButtonExist> ().buttonsHere = false;
				} else {
					thisBed.GetComponent<Renderer> ().enabled = true;
					thisBed.GetComponent<Collider> ().enabled = true;
				}
			}
			foreach (GameObject thisLight in listOfLights)
			{
				thisLight.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisLight.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisLight.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisLight.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisLight.GetComponent<ButtonExist> ().buttonsHere = false;
			}
			foreach (GameObject thisTree in listOfTrees)
			{
				thisTree.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTree.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisTree.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTree.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisTree.GetComponent<ButtonExist> ().buttonsHere = false;
			}
			foreach (GameObject thisTreasure in listOfTreasures)
			{
				thisTreasure.transform.GetChild (0).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTreasure.transform.GetChild (0).gameObject.GetComponent<Collider> ().enabled = false;
				thisTreasure.transform.GetChild (1).gameObject.GetComponent<Renderer> ().enabled = false;
				thisTreasure.transform.GetChild (1).gameObject.GetComponent<Collider> ().enabled = false;
				thisTreasure.GetComponent<ButtonExist> ().buttonsHere = false;
			}
		}
	}
}
