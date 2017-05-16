using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDie : MonoBehaviour {
    Vector3 StartPosition;
	// Use this for initialization
	void Start () {
		StartPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.y <= 0)
		{
			transform.position = StartPosition;
		}
	}
}
