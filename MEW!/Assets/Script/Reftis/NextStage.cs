using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour {

    public int blocks;
    static public int block;

    public int nextblock;
    public int stage;


    public int showblocks;
	void Start () {
        block = blocks;
	}
	
	void Update () {
        showblocks = block;

        if(showblocks == 0)
        {
            Ball.vect.x = 0;
            Ball.vect.y = 0;
            clear.blk = true;
            Line.next = true;
        }

        if(Input.GetMouseButton(0))
        {
            if(clear.blk)
            {              
                stage++;
                block = nextblock;
                nodeath.cheaton = false;
                Line.color = 0;
                Line2.color = 0;
                Ball.color = 0;
                SceneManager.LoadScene("stage" + stage);
                clear.blk = false;
                reset.resetting = true;
            }
        }
	}
}
