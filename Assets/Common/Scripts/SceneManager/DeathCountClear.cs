using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathCountClear : MonoBehaviour {
    public static int KillCount;
    public int ClearCount;
    float timer;
    public Text text;
	// Use this for initialization
	void Start () {
        text.enabled = false;
        KillCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (KillCount >= ClearCount)
        {
            timer += Time.deltaTime;
            text.enabled = true;
            if (timer >= 4)
            {
                SceneManager.LoadScene("SingleLevelSelect");
            }
        }
	}
}
