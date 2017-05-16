using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviingDrone : MonoBehaviour {
    
    Vector3 defaultposition;
    int load = 1;
    public float Spped = 0;
    float returntimer;

	// Use this for initialization
	void Start () {
        
	}

	// Update is called once per frame
	void Update () {
        returntimer += Time.deltaTime;
        if(load == 1){
            this.gameObject.transform.position -= Vector3.forward * Spped;
            if (returntimer >= 5){
                load = 2;
                returntimer = 0;
            }
        }
        if(load == 2){
            this.gameObject.transform.position += Vector3.forward * Spped;
            if(returntimer >= 5){
                load = 1;
                returntimer = 0;
            }
        }
	}
}
