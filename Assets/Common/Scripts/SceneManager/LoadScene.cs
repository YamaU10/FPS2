using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void MulitScene()
	{
		SceneManager.LoadScene("Multi");
	}
	public void SingleScene()
	{
		SceneManager.LoadScene("SingleLevelSelect");
	}
	public void SettingScene()
	{
		SceneManager.LoadScene("Setting");
	}
	public void CustmizScene()
	{
		SceneManager.LoadScene("Custmiz");
	}
}
