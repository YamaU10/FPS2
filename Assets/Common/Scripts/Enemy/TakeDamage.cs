using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {

    private vp_DamageHandler damg;
    public float damage;
    private float timer;

    void OnTriggerStay(Collider other){
        if(other.gameObject.tag.Equals("Player") && timer < Time.time) {
            damg = other.GetComponent<vp_DamageHandler>();
            damg.Damage(damage);
            timer = Time.time + 0.5f;
        }
        if(other.gameObject.tag == "DoomDayDevice" && timer < Time.time){
			damg = other.GetComponent<vp_DamageHandler>();
			damg.Damage(damage);
			timer = Time.time + 0.5f;
        }
    }
}
