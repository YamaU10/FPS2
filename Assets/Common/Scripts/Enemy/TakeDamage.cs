using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {
    private vp_DamageHandler damg;
    public float damage;
    private float timer;
	
    void OnTriigerEnter(Collider col){
        if(col.gameObject.tag.Equals("Player")) {
            damg = col.GetComponent<vp_DamageHandler>();
            timer = Time.time + 0.5f;
        }
    }

    void OnTriggerStay(Collider col){
        if(col.gameObject.tag.Equals("Player") && timer < Time.time) {
			damg = col.GetComponent<vp_DamageHandler>();
            damg.Damage(damage);
            timer = Time.time + 0.5f;
        }
    }
}
