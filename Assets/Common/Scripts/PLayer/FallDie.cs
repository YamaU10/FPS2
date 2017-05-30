using UnityEngine;

public class FallDie : MonoBehaviour
{
    Vector3 StartPosition;
    public GameObject scope;
    vp_FPPlayerDamageHandler vpp;
    public int count = 2;
    // Use this for initialization
    void Start()
    {
        StartPosition = transform.position;
        scope.SetActive(false);
        vpp = GetComponent<vp_FPPlayerDamageHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 1)
        {
            Playerprofile.AllSingleDeathCount += 1;
            count = 3;
        }
        if (count == 2)
        {
            if (vpp.CurrentHealth <= 0)
            {
                count = 1;
            }
        }
        if (count == 3)
        {
            if (vpp.CurrentHealth > 0)
            {
                count = 2;
            }
        }
        if (this.gameObject.transform.position.y <= 0)
        {
            transform.position = StartPosition;
        }
    }
}
