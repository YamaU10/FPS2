using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    vp_Grenade vpG;
	// Use this for initialization
	void Start () {
        vpG = GetComponent<vp_Grenade>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Field" || other.gameObject.tag == "Wall"){
            vpG.LifeTime = 0;
        }
    }
}
