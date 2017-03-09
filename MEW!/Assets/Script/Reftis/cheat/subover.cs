using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class subover : MonoBehaviour {

    public bool line;
    void OnCollisionEnter(Collision collision)
    {
        if (line)
        {
            restartStage.fail = true;
            Ball.vect.x = 0;
            Ball.vect.y = 0;
        }
    }
}
