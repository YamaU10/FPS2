using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelClear : MonoBehaviour {
    //public GameObject[] levelwall;
	public GameObject[] ChackObject;
    // Use this for initialization
    int Action = 0;
   
	void Start () {
		
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
                gameObject.SetActive(false);
                break;
        }

    }
}
