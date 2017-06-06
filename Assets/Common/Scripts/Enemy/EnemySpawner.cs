using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public GameObject Enemy;
    float timer;
    public float InstantiateTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= InstantiateTime){
            Instantiate(Enemy,transform.position, Quaternion.identity);
            timer = 0;
        }
	}
}
