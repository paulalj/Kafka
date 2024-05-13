using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bassall : MonoBehaviour
{
    private float lastHit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && Time.time > lastHit + 0.5f)
        {
            GameObject.FindGameObjectWithTag("Main").GetComponent<MainScript_N2>().VidaCounter(this.tag);
            lastHit = Time.time;
        }
    }
}
