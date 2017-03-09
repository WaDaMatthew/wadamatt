using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

    [SerializeField]
    public GameObject soundon;
    [SerializeField]
    public GameObject soundoff;


    public void Click()
    {
        if (visible.onoff)
        {
            AudioListener.volume = 0;
            soundon.SetActive(false);
            soundoff.SetActive(true);
            visible.onoff = false;
        }
        else
        {
            AudioListener.volume = 1;
            soundon.SetActive(true);
            soundoff.SetActive(false);
            visible.onoff = true;
        }
    }
}
