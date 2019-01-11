using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour {

	private Light myLight;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light>();
		myLight.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter () {
    	myLight.enabled = true;
	}
 
	void OnTriggerExit () {
    	myLight.enabled = false;
	}
}
