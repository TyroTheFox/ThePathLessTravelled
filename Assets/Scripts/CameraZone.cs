using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZone : MonoBehaviour
{
	public Camera camera;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Camera m_MainCamera = Camera.main;
			m_MainCamera.enabled = false;
			m_MainCamera.tag = "Camera";
			camera.enabled = true;
			camera.tag = "MainCamera";
		}
	}
}
