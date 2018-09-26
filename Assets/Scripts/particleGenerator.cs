using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleGenerator : MonoBehaviour {

	public int particleNum = 500;
	public float particleSize = 0.5f;

	public Vector3 size = new Vector3(200f, 50f, 200f);

	// Use this for initialization
	void Start () {

		var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		Vector3 scale = new Vector3(particleSize, particleSize, particleSize);
		go.transform.localScale = scale;

		// go.transform.SetParent(transform);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
