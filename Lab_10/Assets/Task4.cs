using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Box")
        {
            Destroy(col.gameObject, 1.0f);
        }
       
    }
}
