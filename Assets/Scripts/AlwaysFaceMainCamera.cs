using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysFaceMainCamera : MonoBehaviour {

	Camera m_MainCamera;
	
	// Use this for initialization
	void Start () {
		//This gets the Main Camera from the Scene
		m_MainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the camera every frame so it keeps looking at the target
		transform.LookAt(m_MainCamera.transform, transform.up);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); // lock x and z axis to zero
	}
}
