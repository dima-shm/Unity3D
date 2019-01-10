using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task5 : MonoBehaviour {
 public int forceApplied;

    public float sphereSpeed;
    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * sphereSpeed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "BBox")
        {
            Destroy(col.gameObject, 1.0f);
        }

        if (col.gameObject.tag == "GBox")
        {
            col.gameObject.GetComponent<Rigidbody>().AddForce(0, forceApplied, 0);
        }


    }
}
