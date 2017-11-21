using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandleClick : MonoBehaviour {
	
	private GameObject button;
	private GameObject theCharacter;
	private Vector3 buttonLocation;
	private Vector3 charLocation;
	private Vector3 newLocation;

	private GameObject[] listOfLights;
	private GameObject[] listOfTrees;
	private GameObject[] listOfTreasures;
	private GameObject[] listOfBeds;

	// Use this for initialization
	void Start () {
		button = this.gameObject;
		buttonLocation = button.transform.position;
		theCharacter = GameObject.Find("Character");
		charLocation = theCharacter.transform.position;

		listOfLights = GameObject.FindGameObjectsWithTag ("DecoLight");
		listOfTrees = GameObject.FindGameObjectsWithTag ("DecoTree");
		listOfTreasures = GameObject.FindGameObjectsWithTag ("DecoTreasure");
		listOfBeds = GameObject.FindGameObjectsWithTag ("DecoBed");
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void MoveHere() 
	{
		if (transform.parent.tag == "DecoLight") {
			theCharacter.GetComponent<PlayerController> ().shouldMove1 = true;
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
		else if (transform.parent.tag == "DecoTree") {
			theCharacter.GetComponent<PlayerController> ().shouldMove2 = true;
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
		else if (transform.parent.tag == "DecoTreasure") {
			theCharacter.GetComponent<PlayerController> ().shouldMove3 = true;
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
		else if (transform.parent.tag == "DecoBed") {
			theCharacter.GetComponent<PlayerController> ().shouldMove4 = true;
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
