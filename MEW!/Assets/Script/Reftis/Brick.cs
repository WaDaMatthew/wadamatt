using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class Brick : MonoBehaviour {

    public GameObject brick;
    public int color;
    static public int coloring;
    static public bool breaker = false;
    //public AudioClip clip;
    
    void Start () {
        //audioclip = GetComponent<AudioSource>();
	}
	
	void Update () {
        
	}

    void OnCollisionEnter(Collision collision)
    {
        //audioclip.PlayOneShot(clip, 0.7F); 
        
        breaker = true;        
        Destroy(brick);
        NextStage.block--;
        if (breaker && color == 0)
        {
            coloring = 0;
            Brick.breaker = false;
        }

        else if (breaker && color == 1)
        {
            coloring = 1;
            
            Brick.breaker = false;
        }

        else if (breaker && color == 2)
        {
            coloring = 2;

            Brick.breaker = false;
        }

        else if (breaker && color == 3)
        {
            coloring = 3;

            Brick.breaker = false;
        }

        else if (breaker && color == 4)
        {
            coloring = 4;

            Brick.breaker = false;
        }
    }
}
