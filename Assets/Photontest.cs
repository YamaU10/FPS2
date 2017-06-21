using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photontest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings("0.0.0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
