using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotKillCount : MonoBehaviour {
    vp_DamageHandler vpD;
	// Use this for initialization
	void Start () {
        vpD = GetComponent<vp_DamageHandler>();
	}
	
	// Update is called once per frame
	void Update () {
        if (vpD.CurrentHealth <= 0){
            DeathCountClear.KillCount += 1;
            Playerprofile.AllSingleRobotKillCount += 1;
            Debug.Log(Playerprofile.AllSingleRobotKillCount);
        }
	}
}
