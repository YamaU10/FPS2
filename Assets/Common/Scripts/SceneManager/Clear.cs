using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Clear : MonoBehaviour {
	bool is_Onclearfield = false;
	public Text text;
	float timer;
	public GameObject cubeWall;
	// Use this for initialization
	void Start () {
		text.enabled = false;
		cubeWall.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F))
		{
			if (is_Onclearfield)
			{
				text.enabled = true;
				if (timer >= 3)
				{
					SceneManager.LoadScene("SingleLevelSelect");
				}
			}
		}
	}
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "ClearField")
		{
			is_Onclearfield = true;
			cubeWall.SetActive(true);
			timer += Time.deltaTime;
			if (Input.GetKeyDown(KeyCode.F))
			{
				text.enabled = true;
			}
			if (timer >= 3)
			{
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
