using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSecondScene : MonoBehaviour {

	public string sceneName;

	void OnTriggerEnter () {
    	SceneManager.LoadScene(sceneName);
	}	
}