using System.Collections;
using System.Collections.Generic;
using SpriteMan3D;
using UnityEngine;

public class CameraZone : MonoBehaviour
{
	public Camera camera;
	public Camera audioListener;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Camera m_MainCamera = Camera.main;
			m_MainCamera.enabled = false;
			m_MainCamera.tag = "Camera";
			m_MainCamera.GetComponent<AudioListener>().enabled = false;
			camera.enabled = true;
			camera.tag = "MainCamera";
			audioListener.enabled = true;
			if(other.GetComponent<PersonPlayerController>() != null)
				other.GetComponent<PersonPlayerController>().currentCamera = camera.transform;
		}
	}
}
