using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathObjectnoClear : MonoBehaviour {

	public GameObject[] ChackObject;
	public Text noclear;
	float timer;
	// Use this for initialization
	int Action = 0;

	void Start()
	{
		noclear.enabled = false;
	}

	// Update is called once per frame
	void Update()
	{
		switch (Action)
		{
			case 0:
				int end = 1;

				for (int i = 0; i < ChackObject.Length; ++i)
				{
					if (ChackObject[i].activeSelf == true)
					{
						end = 0;
						break;
					}
				}
				if (end == 1)
				{
					Action = 1;
				}
				break;
			case 1:
				timer += Time.deltaTime;
				noclear.enabled = true;
				if (timer >= 4)
				{
					SceneManager.LoadScene("SingleLevelSelect");
				}
				break;
		}

	}
}
