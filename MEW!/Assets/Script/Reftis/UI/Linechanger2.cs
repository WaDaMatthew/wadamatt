using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Linechanger2 : MonoBehaviour {

    public Sprite whitelinechanger;
    public Sprite redlinechanger;
    public Sprite yellowlinechanger;
    public Sprite greenlinechanger;
    public Sprite bluelinechanger;

    void Start () {
        
    }

    void Update()
    {
        switch (Line2.color)
        {
            case 0:
                gameObject.GetComponent<Image>().sprite = redlinechanger;
                Line2.color = 0;
                break;
            case 1:
                switch (Line2.staticlimit)
                {
                    case 2:
                        gameObject.GetComponent<Image>().sprite = whitelinechanger;
                        Line2.color = 1;
                        break;

                    case 3:
                    case 4:
                    case 5:
                        gameObject.GetComponent<Image>().sprite = yellowlinechanger;
                        Line2.color = 1;
                        break;
                }
                break;
            case 2:
                switch (Line2.staticlimit)
                {
                    case 2:
                    case 3:
                        gameObject.GetComponent<Image>().sprite = whitelinechanger;
                        Line2.color = 2;
                        break;
                    case 4:
                    case 5:
                        gameObject.GetComponent<Image>().sprite = bluelinechanger;
                        Line2.color = 2;
                        break;
                }
                break;
            case 3:
                switch (Line2.staticlimit)
                {
                    case 4:
                        gameObject.GetComponent<Image>().sprite = whitelinechanger;
                        Line2.color = 3;
                        break;
                    case 5:
                        gameObject.GetComponent<Image>().sprite = greenlinechanger;
                        Line2.color = 3;
                        break;
                }
                break;
            case 4:
                gameObject.GetComponent<Image>().sprite = whitelinechanger;
                Line2.color = 4;
                break;
        }
    }

    public void Click()
    {
        if (reset.resetting)
        {

            reset.resetting = false;
        }

        if (!Line2.next)
        {
            Line2.clicked = true;
            Line2.color++;
            if (Line2.color == Line2.staticlimit)
            {
                Line2.color = 0;
            }
        }   
        
    }
}
