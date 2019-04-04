using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
	//New character scale
    public float newSize = 1;
    // Start is called before the first frame update
    void Start()
    {
		//Find player object and update its transform with the new scale value
        GameObject.FindWithTag("Player").transform.localScale = new Vector3(newSize, newSize, newSize);
		//Find all Party Members and update transform with the new scale value
        foreach (var character in GameObject.FindGameObjectsWithTag("PartyMember"))
        {
            character.transform.localScale = new Vector3(newSize, newSize, newSize);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
