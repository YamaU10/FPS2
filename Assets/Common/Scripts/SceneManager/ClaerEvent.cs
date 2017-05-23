using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ClaerEvent : MonoBehaviour {
	public Text text1;
	public Text text2;
	GameObject cubewall;
	bool is_Onclearfield = false;
	// Use this for initialization
	void Start () {
		text1.enabled = false;
		text2.enabled = false;
		cubewall = GameObject.Find("CubeWall");
		cubewall.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F))
		{
			if (is_Onclearfield)
			{
				text1.enabled = true;
				text2.enabled = true;
				SceneManager.LoadScene("SingleLevelSelect");
			}
		}

	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "ClearField")
		{
			is_Onclearfield = true;
			if (Input.GetKeyDown(KeyCode.F))
			{
				text1.enabled = true;
				text2.enabled = true;
				SceneManager.LoadScene("SingleLevelSelect");
			}
		}
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "ClearField")
		{
			is_Onclearfield = false;
		}
	}
}
