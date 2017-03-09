using UnityEngine;
using System.Collections;

public class clear : MonoBehaviour {
    public GameObject obj;

    public GameObject obj2;
    static public bool blk = false;
	void Start () {
        obj.SetActive(false);
        obj2.SetActive(false);
    }
	
	void Update () {
	    if(blk)
        {
            obj.SetActive(true);
        }

        if(restartStage.fail)
        {
            obj2.SetActive(true);
        }
	}
}
