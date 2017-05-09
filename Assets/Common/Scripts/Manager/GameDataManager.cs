using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour {

	public static PlayerData data;


	public static void Load(){
		data = new PlayerData ();
		data.experience = LoadExperience();// 経験値読み込み
	}

	// 経験値保存
	public static void SaveExperience(){
		PlayerPrefs.SetInt (SaveKey.Experience, data.experience);
	}

	// 1. StartでPlayerDataのexperienceに値を入れてDebugで確認しよう
	public void Start(){
		Load ();
		data.experience = 0;
		SaveExperience ();
	}
	// 2. 経験値を保存してみよう
	public void Update(){
		if (Input.GetKeyDown (KeyCode.Y)) {
			SaveExperience ();
			Debug.Log (data.experience);
		}
	}
    // 3. 経験値読み込んでデバッグするスクリプト
	static int LoadExperience(){
		int EXP;
		EXP = PlayerPrefs.GetInt (SaveKey.Experience);
		return EXP;
	}
	public static void AddExp(int EXPPoint){
		data.experience += EXPPoint;
		SaveExperience ();
	}
}
