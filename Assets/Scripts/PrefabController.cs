using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)) {
			var ps = (GameObject)Resources.Load("PS");
			var go = Instantiate(ps);
			go.transform.SetParent(transform, false);
			go.GetComponent<PSController>().mat = GameObject.Find("Particles").GetComponent<ParticlesController>().currentMat;
		}
		
	}
}
