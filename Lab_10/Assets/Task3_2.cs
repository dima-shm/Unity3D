using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3_2 : MonoBehaviour {

	public int forceApplied;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter(Collision col)
    {
        col.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, forceApplied);
    }
}
