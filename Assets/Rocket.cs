using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    GameObject player;
    vp_FPPlayerDamageHandler DamegeScript;
	Transform target;
	public float speed = 1.0f;
    public GameObject exprosion;
    float dis;

    void Start()
    {
        player = GameObject.Find("PA_ArchlightBomber");
        target = player.transform;
        DamegeScript = player.GetComponent <vp_FPPlayerDamageHandler>();
    }

    void Update()
	{
        //hit
        dis = Vector3.Distance(target.position, transform.position);
        if (dis <= 1.0f) {
            Instantiate(exprosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
			//DamegeScript.Damage(DamegePow);
		}

        //move
		float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //DamegeScript.Damage(DamegePow);
		}
		Destroy(gameObject);
	}
}
