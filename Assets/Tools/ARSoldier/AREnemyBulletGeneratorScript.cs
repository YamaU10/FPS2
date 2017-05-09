using UnityEngine;

public class AREnemyBulletGeneratorScript : MonoBehaviour {
    public GameObject bullet;
    public GameObject objA;
    public GameObject objB;
    float timer;
	public AudioSource GunSound;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        float dis = Vector3.Distance(objA.transform.position, objB.transform.position);
        if (dis < 20)
        {
            if (AREnemyBulletSizeScript.UseAREnemyBulletSize > 0)
            {
                if (AREnemyBulletSizeScript.AREnemyBulletSize > -1)
                {
					if (AREnemySoldierScrpt.timer > 3)
					{
						if (timer >= 0.1)
						{
							AREnemySoldierScrpt.animator.SetBool("is_reload", false);
							Instantiate(bullet, transform.position, transform.rotation);
							timer = 0;
							GunSound.Play();
							AREnemyBulletSizeScript.UseAREnemyBulletSize -= 1;
						}
					}
                }
            }
        }
        if (EnemyScript.enemyHP < 1)
        {
            GetComponent<AREnemyBulletGeneratorScript>().enabled = false;
        }
        else
        {
            GetComponent<AREnemyBulletGeneratorScript>().enabled = true;
        }
    }
}
