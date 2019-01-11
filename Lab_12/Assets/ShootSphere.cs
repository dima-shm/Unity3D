using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShootSphere : MonoBehaviour {

	private int count;
	public Text countText;

	// Use this for initialization
	void Start () {
		count = 0;
		countText.text = "Count: " + count.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		shoot();
	}

	public void shoot(){
        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)){
				Debug.DrawRay ( ray.origin, ray.direction * 100, Color.red );
				//print(hit.transform.gameObject.tag);
                if (hit.transform.gameObject.tag == "GlowingSphere"){
					 Destroy(hit.transform.gameObject);
					 count += 1;
					 countText.text = "Count: " + count.ToString();

				}
            }
        }
     }  


}
