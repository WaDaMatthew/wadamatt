using UnityEngine;
using System.Collections;

public class visible : MonoBehaviour
{
    [SerializeField]
    public GameObject soundon;
    [SerializeField]
    public GameObject soundoff;
    [SerializeField]
    public GameObject vibon;
    [SerializeField]
    public GameObject viboff;

    public static bool onoff = true;
    public static bool vibonoff = true;

    void Start()
    {
        soundon.SetActive(true);
        soundoff.SetActive(false);
        vibon.SetActive(true);
        viboff.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}