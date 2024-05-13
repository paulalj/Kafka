using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rates : MonoBehaviour
{
    private float velocitat_rata = 3;
    private float lastHit;
    private int limit_sup = 540;
    private int limit_inf = 297;

    void Update()
    {
        transform.position += new Vector3(velocitat_rata, 0, 0);

        if ((transform.position.x >= limit_sup) || (transform.position.x <= limit_inf))
        {
            velocitat_rata *= -1;
            transform.Rotate(0, 180, 0);
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
