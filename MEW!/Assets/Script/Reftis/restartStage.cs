using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class restartStage : MonoBehaviour {

    static public bool fail = false;
    public int stage;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            fail = false;
            Brick.coloring = 0;
            Line.color = 0;
            Line2.color = 0;
            SceneManager.LoadScene("stage" + stage);
        }
    }
}
