using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public float newSize = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Player").transform.localScale = new Vector3(newSize, newSize, newSize);
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
