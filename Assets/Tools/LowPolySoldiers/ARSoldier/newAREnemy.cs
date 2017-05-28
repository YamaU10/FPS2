using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newAREnemy : MonoBehaviour {

	public static Animator animator;
	float dis;
	GameObject target;
	public float maximumRotateSpeed = 40;
	public float minimumTimeToReachTarget = 0.5f;
	Transform _transform;
	Transform _cameraTransform;
	float _velocity;
    private vp_DamageHandler vpD;
	public GameObject turret;

	// Use this for initialization
	void Start()
	{
		animator = GetComponent<Animator>();
		target = GameObject.Find("FPSCamera");
		_transform = transform;
		_cameraTransform = Camera.main.transform;
		vpD = GetComponent<vp_DamageHandler>();
	}

	// Update is called once per frame
	void Update()
	{
		dis = Vector3.Distance(target.transform.position, transform.position);
		if (dis <= 50)
		{
			Rotation();
		}
		if (vpD.CurrentHealth <= 0)
		{
			animator.SetBool("is_death", true);
            Playerprofile.AllSinglePlayerKillCount += 1;
			GetComponent<vp_DamageHandler>().enabled = false;
			GetComponent<BoxCollider>().enabled = false;
            GetComponent<newAREnemy>().enabled = false;
			turret.SetActive(false);
		}
		else
		{
			GetComponent<vp_DamageHandler>().enabled = true;
			GetComponent<BoxCollider>().enabled = true;
            GetComponent<newAREnemy>().enabled = true;
			turret.SetActive(true);
			animator.SetBool("is_death", false);
		}
	}
	void Rotation()
	{
		var newRotation = Quaternion.LookRotation(_cameraTransform.position - _transform.position).eulerAngles;
		var angles = _transform.rotation.eulerAngles;
		_transform.rotation = Quaternion.Euler(angles.x, Mathf.SmoothDampAngle(angles.y, newRotation.y, ref _velocity, minimumTimeToReachTarget, maximumRotateSpeed), angles.z);
	}
}
