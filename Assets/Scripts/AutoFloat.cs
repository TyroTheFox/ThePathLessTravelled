using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFloat : MonoBehaviour
{

    public float speed = 1;
    public float distance = 0.5f;
    public float tolerance = 0.05f;
    private bool floatUp;
    private Vector3 up;
    private Vector3 down;
    private float startTime;
    private float journeyLength;
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        var localPosition = transform.localPosition;
        up = new Vector3(0, localPosition.y + distance, 0);
        down = new Vector3(0, localPosition.y - distance, 0);
        journeyLength = Vector3.Distance(up, down);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        if (floatUp)
        {
            transform.localPosition = Vector3.Lerp(down, up, fracJourney);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(up, down, fracJourney);
        }

        if (fracJourney > (1 - tolerance))
        {
            startTime = Time.time;
            floatUp = !floatUp;
        }
    }
}
