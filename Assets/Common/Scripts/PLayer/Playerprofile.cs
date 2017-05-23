using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playerprofile : MonoBehaviour
{
    public static bool profile = false;
    public static int AllPlayerKillCount;
    public static int AllPlayerDeathCount;
    public static float KD;

    // Use this for initialization
    void Start()
    {
        if (!profile)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
