using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{

    public GameObject scopeOverray;

    private bool isScoped = false;

    public GameObject weaponcamera;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            isScoped = true;
            if (isScoped)
                StartCoroutine(OnScoped());
        }
        else
            OnunScoped();
    }
    void OnunScoped()
    {
        scopeOverray.SetActive(false);
        weaponcamera.SetActive(true);
    }
    IEnumerator OnScoped()
    {
        yield return new WaitForSeconds(.25f);
        scopeOverray.SetActive(true);
        weaponcamera.SetActive(false);
    }
}
