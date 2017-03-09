using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class scratchtimer : MonoBehaviour {

    private float done = 1.0F;
    static public bool end = false;
    Text textlog;

    void Update()
    {
        if (!end && !timerAttack.end)
        {
            if (TouchEarth.clicked && TouchEarth.scratch >2)
            {
                 done = 1.0F;
                 TouchEarth.scratch = 0;
            }

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
                textlog.text = "Game Over";
            }
        }
    }
}
