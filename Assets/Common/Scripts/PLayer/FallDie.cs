using UnityEngine;

public class FallDie : MonoBehaviour {
    Vector3 StartPosition;
    public GameObject scope;
    vp_FPPlayerDamageHandler vpp;
	// Use this for initialization
	void Start () {
		StartPosition = transform.position;
        scope.SetActive(false);
        vpp = GetComponent<vp_FPPlayerDamageHandler>();
	}
	
	// Update is called once per frame
	void Update () {
        if(vpp.CurrentHealth >= 0)
        {
            Playerprofile.AllSingleDeathCount += 1;
        }
		if (this.gameObject.transform.position.y <= 0)
		{
			transform.position = StartPosition;
		}
	}
}
