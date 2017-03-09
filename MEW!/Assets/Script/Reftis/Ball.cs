using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed;
    public float speeder;

    public int showcolor;

    public Sprite whiteball;
    public Sprite redball;
    public Sprite yellowball;
    public Sprite blueball;
    public Sprite greenball;
    public AudioSource audioclip;

    public int direction = 0;

    static public Vector3 vect;
    public Vector3 SaveVec3;
    public float step ;
    public float xMove; //x축으로 이동할 양 
    public float yMove; //y축으로 이동할양 
    
    
    static public int color = 0;


    void Start()
    {
        
        gameObject.GetComponent<Image>().sprite = whiteball;
        SaveVec3 = transform.position;
        step = speed * Time.deltaTime;
        xMove = 5 * speed * Time.deltaTime;
        yMove = 5 * speed * Time.deltaTime;
        vect = new Vector3(xMove, yMove, 0);
    }

    void Update()
    {
        showcolor = color;
        if (reset.resetting)
        {
            Brick.coloring = 0;
            gameObject.GetComponent<Image>().sprite = whiteball;
            color = 0;
            Line.color = 0;
            Debug.Log(Line.color);
            Line.next = false;
            reset.resetting = false;
            Line.checker = true;
        }

        this.transform.Translate(vect);  //이동
        switch (Brick.coloring)
        {
            case 0:
                color = 0;
                break;
            case 1:
                color = 1;
                break;
            case 2:
                color = 2;
                break;
            case 3:
                color = 3;
                break;
            case 4:
                gameObject.GetComponent<Image>().sprite = greenball;
                color = 4;
                break;
        }
        switch (color)
        {
            case 0:
                gameObject.GetComponent<Image>().sprite = whiteball;
                break;
            case 1:
                gameObject.GetComponent<Image>().sprite = redball;
                break;
            case 2:
                gameObject.GetComponent<Image>().sprite = yellowball;
                break;
            case 3:
                gameObject.GetComponent<Image>().sprite = blueball;
                break;
            case 4:
                gameObject.GetComponent<Image>().sprite = greenball;
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        audioclip.Play();
        Vector3 incomingVector = SaveVec3;
        incomingVector = incomingVector.normalized;

        Vector3 normalVector = collision.contacts[0].normal;

        Vector3 reflectVector = Vector3.Reflect(incomingVector, normalVector);
        reflectVector = reflectVector.normalized;
        SaveVec3 = reflectVector;
        reflector(reflectVector);
    }

    void reflector(Vector3 vector)
    {
        vector.x *= 4 + speeder;
        vector.y *= 4 + speeder;
        vect = vector;
        vect.y *= 4;
        


        if (speeder < 5)
        {
            speeder += 0.1f;
        }

        else
        {
            speeder = 5;
        }
    }
}
