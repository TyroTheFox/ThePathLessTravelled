using UnityEngine;
using System.Collections;

public class ScreenshotMaker : MonoBehaviour {
	public int ScreenShotMultiplier = 1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.C)) {
			QualitySettings.lodBias = 20;
			ScreenCapture.CaptureScreenshot(Time.renderedFrameCount.ToString()+ ".png", ScreenShotMultiplier);
		}
	}
}
