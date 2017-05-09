using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyWall : MonoBehaviour {
	public GameObject openCube;
	public GameObject openCube2;
	public Text text;
	public GameObject openCube3;
	float timer;
	bool is_Onclearfield = false;
	// Use this for initialization
	void Start () {
		openCube = GameObject.Find("OpenCube");
		openCube2 = GameObject.Find("OpenCube2");
		openCube3 = GameObject.Find("OpenCube3");
		openCube2.SetActive(true);
		text.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.y >= 110)
		{
			if (this.gameObject.transform.position.x >= 132)
			{
				openCube2.SetActive(false);
				openCube3.SetActive(false);
			}
		}
		/*if (this.gameObject.transform.position.x >= 90 && this.gameObject.transform.position.x <= 100)
		{
			if(transform.position.y<=109){
				if (this.gameObject.transform.position.z <= -109)
				{
					timer += Time.deltaTime;
					text.enabled = true;
					Debug.Log(timer);
					if (timer >= 3)
					{
						SceneManager.LoadScene("SingleLevelSelect");
					}
				}
			}
		}*/
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
