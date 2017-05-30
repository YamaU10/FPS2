using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieContoroller : MonoBehaviour
{
    Animator animator;
    public Transform target;
    NavMeshAgent agent;
    float dis;
    vp_DamageHandler vpD;

    // Use this for initialization
    void Start()
    {
        GameObject Player = GameObject.Find("FPSCamera");
        target = Player.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        vpD = GetComponent<vp_DamageHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        dis = Vector3.Distance(transform.position,target.transform.position);
        if (dis <= 2.5f)
        {
            agent.Stop();
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
        if (dis > 2.5f)
        {
            agent.Resume();
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }
        if(GetComponent<vp_DamageHandler>().CurrentHealth <= 0){
            agent.Stop();
            GetComponent<vp_DamageHandler>().enabled = false;
            animator.SetBool("attack", false);
            animator.SetBool("walk", false);
            animator.SetBool("zombiedeath",true);
            GetComponent<BoxCollider>().enabled = false;

        }else{
            animator.SetBool("zombiedeath", false);
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<vp_DamageHandler>().enabled = true;
        }
    }
}
