using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision myCollision) {
		if(myCollision.gameObject.name == "Floor") {
			Debug.Log("Hit the floor");
		} else if(myCollision.gameObject.name == "Wall") {
			Debug.Log("Hit the wall");
		}		
	}
}