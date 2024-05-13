using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mans : MonoBehaviour
{

    private float velocitat_ma1 = 2;
    private float velocitat_ma2 = 3;
    private float velocitat_ma3 = 4;
    private float velocitat_ma4 = 3;
    private float lastHit;
    private int limit_sup = 145;
    private int limit_inf = 111;



    void Update()
    {
        if(this.tag == "Ma1")
        {
            transform.Translate(0, 0, velocitat_ma1);

            if ((transform.position.y >= limit_sup) || (transform.position.y <= limit_inf))
            {
                velocitat_ma1 = -velocitat_ma1;
            }
        }
        else if (this.tag == "Ma2")
        {
            transform.Translate(0, 0, velocitat_ma2);

            if ((transform.position.y >= limit_sup) || (transform.position.y <= limit_inf))
            {
                velocitat_ma2 = -velocitat_ma2;
            }
        }
        else if (this.tag == "Ma3")
        {
            transform.Translate(0, 0, velocitat_ma3);

            if ((transform.position.y >= limit_sup) || (transform.position.y <= limit_inf))
            {
                velocitat_ma3 = -velocitat_ma3;
            }
        }
        else if (this.tag == "Ma4")
        {
            transform.Translate(0, 0, velocitat_ma4);

            if ((transform.position.y >= limit_sup) || (transform.position.y <= limit_inf))
            {
                velocitat_ma4 = -velocitat_ma4;
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
