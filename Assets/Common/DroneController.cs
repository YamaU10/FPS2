using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneController : MonoBehaviour
{
    Vector3 startposition;
    float dis;
    public AudioSource sound01;
    vp_FPController vpC;
    public Text text;
    bool isGrounded;
    CharacterController CC;
    // Use this for initialization
    void Start()
    {
        startposition = transform.position;
        vpC = GetComponent<vp_FPController>();
        CC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dis > 40)
        {
            text.enabled = true;
            if (dis > 60)
            {
                transform.position = startposition;
            }
        }
        else
        {
            text.enabled = false;
        }
        if (CC.isGrounded)
        {
            sound01.Stop();
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            dis = transform.position.y - startposition.y;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            sound01.PlayOneShot(sound01.clip);
        }
    }
}
