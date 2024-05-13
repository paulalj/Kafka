using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cames : MonoBehaviour
{

    private float velocitat_peu1 = 2;
    private float velocitat_peu2 = 3;
    private float velocitat_peu3 = 4;
    private float velocitat_peu4 = 3;
    private float lastHit;
    private int limit_sup = 267;
    private int limit_inf = 207;

    void Update()
    {
        if (this.tag == "Peu1")
        {
            transform.Translate(0, velocitat_peu1, 0);

            if ((transform.position.x >= limit_sup) || (transform.position.x <= limit_inf))
            {
                velocitat_peu1 = -velocitat_peu1;
            }
        }
        else if (this.tag == "Peu2")
        {
            transform.Translate(0, velocitat_peu2, 0);

            if ((transform.position.x >= limit_sup) || (transform.position.x <= limit_inf))
            {
                velocitat_peu2 = -velocitat_peu2;
            }
        }
        else if (this.tag == "Peu3")
        {
            transform.Translate(0, velocitat_peu3, 0);

            if ((transform.position.x >= limit_sup) || (transform.position.x <= limit_inf))
            {
                velocitat_peu3 = -velocitat_peu3;
            }
        }
        else if (this.tag == "Peu4")
        {
            transform.Translate(0, velocitat_peu4, 0);

            if ((transform.position.x >= limit_sup) || (transform.position.x <= limit_inf))
            {
                velocitat_peu4 = -velocitat_peu4;
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && Time.time > lastHit + 0.5f)
        {
            GameObject.FindGameObjectWithTag("Main").GetComponent<MainScript_N2>().VidaCounter(this.tag);
            lastHit = Time.time;
        }
    }
}
