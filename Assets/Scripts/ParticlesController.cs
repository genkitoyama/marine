using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesController : MonoBehaviour {

	public ParticleSystem ps1;
	public ParticleSystem ps2;

	public Material mat1;
	public Material mat2;

	public Material currentMat;

	Vector3 position;

	bool isStop = false;
	 public bool isChangeMat = false;
	int count = 0;

	// Use this for initialization
	void Start () {
		position = transform.position;
		currentMat = mat1;

		if(!ps1.main.loop){
			Destroy(gameObject, (float)ps1.main.duration);
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if(isStop){
			if(ps1.isPlaying) ps1.Pause();
			if(ps2.isPlaying) ps2.Pause();
		}else{
			if(ps1.isPaused) ps1.Play();
			if(ps2.isPaused) ps2.Play();
		}

		if(isChangeMat){
			var mat = (count%2 == 1) ? mat1 : mat2;
			currentMat = mat;
			ps1.GetComponent<Renderer>().sharedMaterial = mat;
			ps2.GetComponent<Renderer>().sharedMaterial = mat;
			count++;
			isChangeMat = false;
		}

		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			// Debug.Log("space");
			isStop = !isStop;
		} 

		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			isChangeMat = true;
		}
	}

}
