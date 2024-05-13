using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float velocitatx = 2;
    private float velocitatz = 3;
    private float lastHit;

    void Update()
    {
        transform.position += new Vector3(velocitatx * Time.deltaTime, 0, velocitatz * Time.deltaTime);

        if (transform.position.x <= -10 || transform.position.x >= 10)
        {
            velocitatx = -velocitatx;
        }
        if (transform.position.z <= -10 || transform.position.z >= 10)
        {
            velocitatz = -velocitatz;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && Time.time > lastHit + 0.5f)
        {
            GameObject.FindGameObjectWithTag("GlobalCounter").GetComponent<MainScript>().VidaCounter(this.tag);
            lastHit = Time.time;
        }
    }

}
