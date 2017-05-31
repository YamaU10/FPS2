using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotKillCount : MonoBehaviour {
    int count = 2;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<vp_DamageHandler>().CurrentHealth <= 0){
            DeathCountClear.KillCount += 1;
            Playerprofile.AllSingleRobotKillCount += 1;
            Debug.Log(Playerprofile.AllSingleRobotKillCount);
        }
		if (count == 1)
		{
			DeathCountClear.KillCount += 1;
			Playerprofile.AllSingleRobotKillCount += 1;
			count = 3;
		}
		if (count == 2)
		{
            if (GetComponent<vp_DamageHandler>().CurrentHealth <= 0)
			{
				count = 1;
			}
		}
		if (count == 3)
		{
            if (GetComponent<vp_DamageHandler>().CurrentHealth > 0)
			{
				count = 2;
			}
		}
	}
}
