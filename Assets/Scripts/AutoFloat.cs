using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A simple script intended to make objects appear to float up and down

public class AutoFloat : MonoBehaviour
{
	//Bob speed
    public float speed = 1;
	//Bob distance
    public float distance = 0.5f;
	//Tollerance for when to change direction
    public float tolerance = 0.05f;
	//Bool to check in which direction the object is moving
    private bool floatUp;
	//Up Position
    private Vector3 up;
	//Down Position
    private Vector3 down;
	//Lerp Data
    private float startTime;
    private float journeyLength;
    
    // Start is called before the first frame update
    void Start()
    {
		//Start time
        startTime = Time.time;
		//Local position
        var localPosition = transform.localPosition;
		//Calculate positions relative to the object's original position
        up = new Vector3(0, localPosition.y + distance, 0);
        down = new Vector3(0, localPosition.y - distance, 0);
		//Calculate length of the journey to be made
        journeyLength = Vector3.Distance(up, down);
    }

    // Update is called once per frame
    void Update()
    {
		//Calculate distance covered
        float distCovered = (Time.time - startTime) * speed;
		//Fraction of the journey covered so far
        float fracJourney = distCovered / journeyLength;
		//If floating upwards
        if (floatUp)
        {
            transform.localPosition = Vector3.Lerp(down, up, fracJourney);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(up, down, fracJourney);
        }
		//If the journey fraction is greater than the total minus the tolerance, change direction
        if (fracJourney > (1 - tolerance))
        {
            startTime = Time.time;
            floatUp = !floatUp;
        }
    }
}
