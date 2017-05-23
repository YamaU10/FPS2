using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerprofileText : MonoBehaviour {
	public Text APKC;
    public Text APDC;
    public Text kd;
	// Use this for initialization
	void Start () {
        APKC.text = Playerprofile.AllPlayerKillCount.ToString();
		APDC.text = Playerprofile.AllPlayerDeathCount.ToString();
        Playerprofile.KD = Playerprofile.AllPlayerKillCount / Playerprofile.AllPlayerDeathCount;
		kd.text = Playerprofile.KD.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
