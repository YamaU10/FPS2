using UnityEngine;

public class Playerprofile : MonoBehaviour
{
    public static bool profile = false;
    public static int AllMultiPlayerKillCount = 0;
    public static int AllMultiPlayerDeathCount = 0;
    public static int AllSinglePlayerKillCount = 0;
    public static int AllSingleRobotKillCount = 0;
    public static int AllSingleDeathCount = 0;
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
