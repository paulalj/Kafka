using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vides : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (this.tag == "Vida")
            {
                GameObject.FindGameObjectWithTag("Main").GetComponent<MainScript_N2>().VidaCounter(this.tag);
            }
            Destroy(gameObject);
        }
    }
}
