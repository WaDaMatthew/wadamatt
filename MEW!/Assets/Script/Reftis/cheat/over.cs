using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class over : MonoBehaviour {
    
    void OnCollisionEnter(Collision collision)
    {
         restartStage.fail = true;
         Ball.vect.x = 0;
         Ball.vect.y = 0;
    }
}
