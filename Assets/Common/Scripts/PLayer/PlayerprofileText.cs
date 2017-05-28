using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerprofileText : MonoBehaviour
{
    public Text APMKC;
    public Text APMDC;
    public Text Mkd;
    public Text APSKC;
    public Text ARSKC;
    public Text APSDC;
    public Text PSkd;
    public Text RSkd;
    int arskc;
    float MKD;
    float PSKD;
    float RSKD;
    // Use this for initialization
    void Start()
    {
        APMKC.text = Playerprofile.AllMultiPlayerKillCount.ToString();
        APMDC.text = Playerprofile.AllMultiPlayerDeathCount.ToString();
        MKD = 1.0f * Playerprofile.AllMultiPlayerKillCount / Playerprofile.AllMultiPlayerDeathCount;
        Mkd.text = MKD.ToString("N1");
        APSKC.text = Playerprofile.AllSinglePlayerKillCount.ToString();
        ARSKC.text = Playerprofile.AllSingleRobotKillCount.ToString();
        APSDC.text = Playerprofile.AllSingleDeathCount.ToString();
        PSKD = 1.0f * Playerprofile.AllSinglePlayerKillCount / Playerprofile.AllSingleDeathCount;
        PSkd.text = PSKD.ToString("N1");
        RSKD = 1.0f * Playerprofile.AllSingleRobotKillCount / Playerprofile.AllSingleDeathCount;
        RSkd.text = RSKD.ToString("N1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
