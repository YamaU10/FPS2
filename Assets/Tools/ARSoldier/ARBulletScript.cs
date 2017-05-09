using UnityEngine;

public class ARBulletScript : MonoBehaviour {

    float timer;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * 100f + Vector3.up * 5f;
        //meshrenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > 10f) Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SendMessage("OtherDamageAnimation");
            other.gameObject.SendMessage("ARBulletDamage");
        }
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("ARBulletDamage");
            other.gameObject.SendMessage("OtherDamageAnimation");
        }
        if (other.gameObject.tag == "Field")
        {
            Destroy(this.gameObject);
        }
    }
}
