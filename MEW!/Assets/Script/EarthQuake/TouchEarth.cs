using UnityEngine;
using System.Collections;

public class TouchEarth : MonoBehaviour {

    private Vector2 mousePos;
    private Vector2 mouseClickPos;
    static public int scratch = 0;
    public bool clicker = false;
    static public bool clicked = false;
    static public bool nonclicker = false;

    public void Update()
    {
        if(Input.GetMouseButton(0) && !clicker && !nonclicker)
        {
            if(!clicked)
            {
                mouseClickPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
                clicked = true;         
                Debug.Log(scratch);
            }
            mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x,Input.mousePosition.y));

            if(mousePos.x >= mouseClickPos.x + 2.5 || mousePos.x <= mouseClickPos.x - 2.5 || mousePos.y >= mouseClickPos.y + 2.5 || mousePos.y <= mouseClickPos.y - 2.5)
            {
                scratch++;
                clicked = false;
            }
        }

        else
        {
            clicker = false;
            clicked = false;

            scratch = 0;
        }
    }
}
