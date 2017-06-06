using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamage : MonoBehaviour {

	private vp_DamageHandler damg;
	public float damage;
	private float timer;
    private float timer2;

	void OnTriggerStay(Collider col)
	{
        if (col.gameObject.tag.Equals("Player") && timer < Time.time)
        {
            timer2 += Time.deltaTime;
            if (timer2 >= 10)
            {
                damg = col.GetComponent<vp_DamageHandler>();
                damg.Damage(damage);
                timer = Time.time + 0.5f;
            }
        }
	}
}
