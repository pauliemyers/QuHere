using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowParticles : MonoBehaviour {

	private GameObject[] cubeList;
	private Color randomColor;
	private float maxLife;
	private float currLife;
	public Transform rainbowCube;

	// Use this for initialization
	void Start () {

		StartCoroutine (newParticle ());
		maxLife = 5.0f;
		currLife = 0.0f;
		randomColor = new Color (Random.Range(0.0f, 255.0f), Random.Range(0.0f, 255.0f), Random.Range(0.0f, 255.0f), 1.0f);
		
	}
	
	// Update is called once per frame
	void Update() {
		cubeList = GameObject.FindGameObjectsWithTag ("RainbowCube");
		foreach (GameObject thisCube in cubeList) {
			thisCube.transform.Rotate(1, 0, 0);
			randomColor = new Color (Random.Range(100.0f, 255.0f), Random.Range(0.0f, 50.0f), Random.Range(0.0f, 255.0f), 1.0f);
			thisCube.GetComponent<Renderer>().material.color = randomColor;
			thisCube.transform.Translate (Random.Range(-1.0f, 1.0f),Random.Range(-1.0f, 1.0f),Random.Range(-1.0f, 1.0f));
		}
		currLife += Time.deltaTime;
	}

	IEnumerator newParticle() {

		while (currLife <= maxLife) {
			yield return new WaitForSeconds (0.1f);
			Instantiate (rainbowCube);
		}



	}



	}
