using UnityEngine;
using System.Collections;

public class Vibration : MonoBehaviour
{
    [SerializeField]
    public GameObject vibon;
    [SerializeField]
    public GameObject viboff;

    public void Click()
    {
        if (visible.vibonoff)
        {
            vibon.SetActive(false);
            viboff.SetActive(true);
            visible.vibonoff = false;
        }

        else
        {
            vibon.SetActive(true);
            viboff.SetActive(false);
            visible.vibonoff = true;
        }
    }
}