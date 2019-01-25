using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using SeedValue;
using UnityEngine;
using UnityEngine.Events;

public class AlterSpriteBasedOnMainCamera : MonoBehaviour {

	public CharacterController m_CharacterController;
	public int sidesOfCharacter = 0;
	Camera m_MainCamera;
	private float currentAngleToMainCamera;
	public Transform m_SpirteBoard;
	private float segmentSize;

	public UnityEvent[] AnimationStates;
	
	// Use this for initialization
	void Start ()
	{
		m_MainCamera = Camera.main;
		currentAngleToMainCamera = 0;
		CalculateAngleToCamera();
		segmentSize = 360 / (float)sidesOfCharacter;
	}
	
	// Update is called once per frame
	void Update ()
	{
		CalculateAngleToCamera();
		bool foundAngle = false;
		int noOfSidesChecked = 1;
		int foundSide = 0;
		float a = currentAngleToMainCamera / segmentSize;
		do
		{
			if (a < noOfSidesChecked)
			{
				foundSide = noOfSidesChecked - 1;
				foundAngle = true;
			}
			else
			{
				noOfSidesChecked++;
			}

			if (noOfSidesChecked > sidesOfCharacter)
			{
				foundSide = -1;
				foundAngle = true;
			}
		} while (!foundAngle);

		if (foundSide != -1)
		{
			AnimationStates[foundSide].Invoke();
		}
	}

	void CalculateAngleToCamera()
	{
		currentAngleToMainCamera = Vector3.Angle(m_CharacterController.transform.forward, (m_MainCamera.transform.position - transform.position).normalized);
		Debug.Log("<color=red>Current Angle to Main Camera:</color> " + currentAngleToMainCamera);
	}
}
