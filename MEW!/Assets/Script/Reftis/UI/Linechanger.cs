using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Linechanger : MonoBehaviour {

    public Sprite whitelinechanger;
    public Sprite redlinechanger;
    public Sprite yellowlinechanger;
    public Sprite bluelinechanger;
    public Sprite greenlinechanger;
    

    void Start () {
        
    }
	
	void Update () {
        switch (Line.color)
        {
            case 0:
                gameObject.GetComponent<Image>().sprite = redlinechanger;
                Line.color = 0;
                break;
            case 1:
                switch(Line.staticlimit)
                {
                    case 2:
                    gameObject.GetComponent<Image>().sprite = whitelinechanger;
                    Line.color = 1;
                    break;

                    case 3:
                    case 4:
                    case 5:
                        gameObject.GetComponent<Image>().sprite = yellowlinechanger;
                        Line.color = 1;
                        break;
                }
                break;
            case 2:
                switch(Line.staticlimit)
                {
                    case 2:
                    case 3:
                        gameObject.GetComponent<Image>().sprite = whitelinechanger;
                        Line.color = 2;
                        break;
                    case 4:
                    case 5:
                        gameObject.GetComponent<Image>().sprite = bluelinechanger;
                        Line.color = 2;
                        break;
                }  
                break;
            case 3:
                switch (Line.staticlimit)
                {
                    case 4:
                        gameObject.GetComponent<Image>().sprite = whitelinechanger;
                        Line.color = 3;
                        break;
                    case 5:
                        gameObject.GetComponent<Image>().sprite = greenlinechanger;
                        Line.color = 3;
                        break;
                }
                break;
            case 4:
                gameObject.GetComponent<Image>().sprite = whitelinechanger;
                Line.color = 4;
                break;
        }
    }

    public void Click()
    {
        if (reset.resetting)
        {

            reset.resetting = false;
        }

        if (!Line.next)
        {
            Line.clicked = true;
            Line.color++;
            if (Line.color == Line.staticlimit)
            {
                Line.color = 0;
            }
        }   
        
    }
}
