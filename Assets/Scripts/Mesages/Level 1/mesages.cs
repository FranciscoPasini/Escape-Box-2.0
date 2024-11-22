using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesages : MonoBehaviour
{
    public SpriteRenderer keys;
    public SpriteRenderer careful;
    public SpriteRenderer good;
    public SpriteRenderer A;
    public SpriteRenderer D;
    public SpriteRenderer W;

    public bool wKey = false;
    public bool aKey = false;
    public bool dKey = false;

    [SerializeField] private PauseScript pauseScript;

    void Update()
    {
        if (pauseScript.Pause == false)
        {
            if (Input.GetKey("w"))
            {
                wKey = true;
                W.enabled = true;
            }
            if (Input.GetKey("a"))
            {
                aKey = true;
                A.enabled = true;
            }
            if (Input.GetKey("d"))
            {
                dKey = true;
                D.enabled = true;
            }

            if (wKey == true && aKey == true && dKey == true)
            {
                SetAllMesagesOff();
            }
        }
    }

    private void SetAllMesagesOff()
    {
        keys.enabled = false;
        good.enabled = true;
        careful.enabled = true;
        A.enabled = false;
        D.enabled = false;
        W.enabled = false;
    }
}
