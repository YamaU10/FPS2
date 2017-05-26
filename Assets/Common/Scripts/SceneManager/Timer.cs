using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	public float timer;
	float timer2;
	public Text noclear;
    Vector3 startposition;
	// Use this for initialization
	void Start () {
		//GetComponent<Text>().text = ((int)timer).ToString();
		noclear.enabled = false;
		timer2 = timer + 3;
        startposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		timer2 -= Time.deltaTime;
		GetComponent<Text>().text=((int)timer).ToString();


        if (timer <= 0)
        {
            noclear.enabled = true;
            timer = 0;
            transform.position = startposition;
            if (timer2 <= 0)
            {
                SceneManager.LoadScene("SingleLevelSelect");
            }
        }
	}
}
