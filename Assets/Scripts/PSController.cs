using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSController : MonoBehaviour {

	public Material mat;

	void Awake () {
		mat = GameObject.Find("Particles").GetComponent<ParticlesController>().currentMat;
	}

	// Use this for initialization
	void Start () {
		var ps = GetComponent<ParticleSystem>();
		ps.GetComponent<Renderer>().sharedMaterial = mat;
		if(!ps.main.loop){
			Destroy(gameObject, (float)ps.main.duration);
		}
	}
	
	// Update is called once per frame
	void Update () {
		bool isChangeMat = GameObject.Find("Particles").GetComponent<ParticlesController>().isChangeMat;
		if(isChangeMat){
			mat = GameObject.Find("Particles").GetComponent<ParticlesController>().currentMat;
			GetComponent<ParticleSystem>().GetComponent<Renderer>().sharedMaterial = mat;
			isChangeMat = false;
		}
	}
}
