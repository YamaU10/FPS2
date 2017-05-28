using UnityEngine;
using UnityEngine.AI;

public class AREnemySoldierScrpt : MonoBehaviour {
	public static Animator animator;
    public Transform _target;
    NavMeshAgent _agent;
    public static int enemyHP = 100;
    public GameObject objA;
    public GameObject objB;
	public static float timer;
    public float maximumRotateSpeed = 40;
    public float minimumTimeToReachTarget = 0.5f;
    Transform _transform;
    Transform _cameraTransform;
    float _velocity;
    // Use this for initializtion
    void Start()
    {
        animator = GetComponent<Animator>();
		GameObject Player = GameObject.Find("FPSCamera");
        _target = Player.transform;
        _agent = this.GetComponent<NavMeshAgent>();
        _transform = transform;
        _cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        _agent.SetDestination(_target.position);
        Vector3 Apos = objA.transform.position;
        Vector3 Bpos = objB.transform.position;
        float dis = Vector3.Distance(Apos, Bpos);
        //Debug.Log(dis);;
        if (dis > 20)
        {
            animator.SetBool("is_walk", true);
			animator.SetBool("is_otherdamage", false);
			animator.SetBool("is_RLdamage", false);
            _agent.Resume();
        }
        else
        {
			animator.SetBool("is_walk", false);
        }
        if (dis < 20)
        {
            animator.SetBool("is_walk", false);
            _agent.Stop();
        }
        else
        {
            animator.SetBool("is_walk", true);
        }
		animator.SetBool("is_otherdamage", false);
        if (AREnemyBulletSizeScript.AREnemyBulletSize > 0)
        {
            if (AREnemyBulletSizeScript.UseAREnemyBulletSize == 0)
            {
                if (timer > 3)
                {
                    timer = 0;
                    animator.SetBool("is_reload", true);
                    AREnemyBulletSizeScript.UseAREnemyBulletSize += 15;
                    AREnemyBulletSizeScript.AREnemyBulletSize -= 15;
                }
                else
                {
                    animator.SetBool("is_reload", false);
                }
            }
        }
        else
        {
            animator.SetBool("is_reload", false);
        }
        var newRotation = Quaternion.LookRotation(_cameraTransform.position - _transform.position).eulerAngles;
        var angles = _transform.rotation.eulerAngles;
        _transform.rotation = Quaternion.Euler(angles.x, Mathf.SmoothDampAngle(angles.y, newRotation.y, ref _velocity, minimumTimeToReachTarget, maximumRotateSpeed),
            angles.z);
    }
    void RLBulletDamage()
    {
        Debug.Log(enemyHP -= 100);
        if (enemyHP < 1)
        {
            animator.SetBool("is_walk", false);
            animator.SetBool("is_reload", false);
			animator.SetBool("is_otherdamage", false);
            animator.SetBool("is_death", true);
            GetComponent<CapsuleCollider>().enabled = false;
			GetComponent<AREnemySoldierScrpt>().enabled = false;
        }
        else
        {
            GetComponent<CapsuleCollider>().enabled = true;
			GetComponent<AREnemySoldierScrpt>().enabled = true;
            animator.SetBool("is_death", false);
        }
    }
    void ARBulletDamage()
    {
		animator.SetBool("is_otherdamage", true);
		Debug.Log(enemyHP -= 12);
        if (enemyHP < 1)
        {
            animator.SetBool("is_walk", false);
            animator.SetBool("is_reload", false);
			animator.SetBool("is_otherdamage", false);
            animator.SetBool("is_death", true);
            GetComponent<CapsuleCollider>().enabled = false;
			GetComponent<AREnemySoldierScrpt>().enabled = false;
        }
        else
        {
            GetComponent<CapsuleCollider>().enabled = true;
            GetComponent<AREnemySoldierScrpt>().enabled = true;
            animator.SetBool("is_death", false);
        }
    }
    void RLDamageAnimation()
    {
        animator.SetBool("is_RLdamage", true);
    }
    void OtherDamageAnimation()
    {
        animator.SetBool("is_otherdamage", true);
    }
}
