using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleMover : MonoBehaviour {

	Vector3 position;
	float accerelation;
	float velocity;
	float noiseFreq;

	// Use this for initialization
	void Start () {
		position = new Vector3(0f,-10f,0f);
		accerelation = 0.01f;
		velocity = 0.0f;

		transform.position = position;
	}
	
	// Update is called once per frame
	void Update () {
		noiseFreq = Mathf.PerlinNoise(Time.time*3.0f, position.y) * 0.5f;

		velocity += accerelation;
		position.y += velocity;

		transform.position = position;
	}
}
