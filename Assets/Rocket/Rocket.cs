using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    GameObject player;
	Transform target;
	public float speed = 1.0f;
    public GameObject exprosion;
    float dis;

    void Start()
    {
        player = GameObject.Find("FPSCamera");
        target = player.transform;
    }

    void Update()
	{
        //hit
        dis = Vector3.Distance(target.position, transform.position);
        if (dis <= 1.0f) {
            Instantiate(exprosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
		}

        //move
		float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            Destroy(gameObject);
        }
    }
}
