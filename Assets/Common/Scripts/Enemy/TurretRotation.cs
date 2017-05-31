using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour {

	public float maximumRotateSpeed = 40;
	public float minimumTimeToReachTarget = 0.5f;
	Transform _transform;
	Transform _cameraTransform;
	float _velocity;

	void Start()
	{
		_transform = transform;
		_cameraTransform = Camera.main.transform;
	}

	void Update()
	{
		var newRotation = Quaternion.LookRotation(_cameraTransform.position - _transform.position).eulerAngles;
		var angles = _transform.rotation.eulerAngles;
		_transform.rotation = Quaternion.Euler(angles.x, Mathf.SmoothDampAngle(angles.y, newRotation.y, ref _velocity, minimumTimeToReachTarget, maximumRotateSpeed), angles.z);
	}
}
