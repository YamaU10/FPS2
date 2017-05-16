using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour {
    public float timer;
    public float speed;
    Vector3 startposition;
    Vector3 MAXposiotion;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * speed;
            startposition = transform.position;
        }
	}
}
