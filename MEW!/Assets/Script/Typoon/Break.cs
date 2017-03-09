using UnityEngine;
using System.Collections;

public class Break : MonoBehaviour {

    public int hp = 10;
    public GameObject breaker;

	void Update()
    {
        if(hp == 0)
        {
            setter.planets--;
            breaker.SetActive(false);
        }
    }

    public void Click()
    {
        if (!Timerattack.end)
        {
            hp--;
        }
    }
}
