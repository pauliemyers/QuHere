using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowBehavior : MonoBehaviour {

	public Material HighLightMaterial;

	private Renderer myRenderer;
		//private Material[] normalMaterials;
	private Material normalMaterial;
		//private Material[] myMaterials;
		//private int numOfMaterials;

			// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer>();
			//normalMaterials = myRenderer.materials;
		normalMaterial = myRenderer.material;
	}
	
		// Update is called once per frame
	void Update () {
	}

	public void HighLight() {
			//for (int i = 0; i < numOfMaterials; i++) {
				//myRenderer.materials[i] = HighLightMaterial;
				//print (myRenderer.materials[i]);
			//}
	myRenderer.material = HighLightMaterial;

	}

	public void NormalRendering() {
			//for (int i = 0; i < numOfMaterials; i++) {
				//this.myRenderer.materials[i] = normalMaterials[i];
			//}
	myRenderer.material = normalMaterial;
	}
//
//	public Material HighLightMaterial;
//
//	private Renderer myRenderer;
//	private Material[] normalMaterials;
//	private Material[] myMaterials;
//
//	void Start () {
//		myRenderer = this.GetComponent<Renderer> ();
//		normalMaterials = myRenderer.materials;
//		myMaterials = myRenderer.materials;
//	}
//
//	public void HighLight() {
////		for (int i = 0; i < myRenderer.materials.Length; i++) {
////			myRenderer.materials[i] = HighLightMaterial;
////		}
//
//		foreach (Material matt in myRenderer.materials) {
//			matt = HighLightMaterial;
//		}
//	}
//
//	public void NormalRendering() {
//		for (int i = 0; i < myRenderer.materials.Length; i++) {
//			myRenderer.materials[i] = normalMaterials [i];
//		}
//	}
}
