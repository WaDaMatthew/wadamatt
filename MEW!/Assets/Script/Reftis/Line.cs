using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Line : MonoBehaviour {

    public int colorlimit;
    static public int staticlimit;
    static public int color = 0;
    static public bool next = false;
    static public bool checker = false;
    
    static public bool clicked = false;

    public Sprite whiteline;
    public Sprite redline;
    public Sprite yellowline;
    public Sprite blueline;
    public Sprite greenline;

    void Start () {

    }
	
	void Update () {
        staticlimit = colorlimit;
        

        switch (color)
        {
            case 0:
                gameObject.GetComponent<Image>().sprite = whiteline;
                break;
            case 1:
                gameObject.GetComponent<Image>().sprite = redline;
                break;
            case 2:
                gameObject.GetComponent<Image>().sprite = yellowline;
                break;
            case 3:
                gameObject.GetComponent<Image>().sprite = blueline;
                break;
            case 4:
                gameObject.GetComponent<Image>().sprite = greenline;
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(!nodeath.cheaton && Ball.color != color)
        {
            restartStage.fail = true;
            Ball.vect.x = 0;
            Ball.vect.y = 0;
        }
    }
}
