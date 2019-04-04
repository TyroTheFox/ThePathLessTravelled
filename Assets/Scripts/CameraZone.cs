using System.Collections;
using System.Collections.Generic;
using SpriteMan3D;
using UnityEngine;

public class CameraZone : MonoBehaviour
{
	//Attributed camera
	public Camera camera;
	//Camera audioListener
	public AudioListener audioListener;

	private void OnTriggerEnter(Collider other)
	{
		//Upon something entering the trigger collision box and it has a 'Player' tag
		if (other.gameObject.CompareTag("Player"))
		{
			//Find and switch off the currently active camera
			Camera m_MainCamera = Camera.main;
			m_MainCamera.enabled = false;
			m_MainCamera.tag = "Camera";
			//Deactivate that camera's audioListener
			m_MainCamera.GetComponent<AudioListener>().enabled = false;
			//Activate this camera as the main, active camera
			camera.enabled = true;
			camera.tag = "MainCamera";
			//Enable this audioListener
			audioListener.enabled = true;
			//If there is a player controller script on the player object, update it's currently active camera object
			if(other.GetComponent<PersonPlayerController>() != null)
				other.GetComponent<PersonPlayerController>().currentCamera = camera.transform;
		}
	}
}
