using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeath : MonoBehaviour {
    
    static public bool cheaton; 

	void Start () {
		
	}
	
	void Update () {

	}

    public void click()
    {
        switch(cheaton)
        {
            case false:
                cheaton = true;
                break;
            case true:
                cheaton = false;
                break;
        }
    }
}
