using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class Timerattack : MonoBehaviour {

    private float done = 30.0F;
    static public bool end = false;

    Text textlog;
    private object scratchtime;

    void Update()
    {
        if (!end && !scratchtimer.end)
        {
            if (done > 0F)
            {
                done -= Time.deltaTime;
                textlog = GetComponent<Text>();
                textlog.text = "Time : " + done + "sec";
            }

            else
            {
                TouchEarth.nonclicker = true;
                end = true;
                textlog = GetComponent<Text>();
                textlog.text = "Time is Over";
            }

            if (setter.planets == 0)
            {
                end = true;
                textlog = GetComponent<Text>();
                textlog.text = "Game Clear";
            }       
        }
    }
}
