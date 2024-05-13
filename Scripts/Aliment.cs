using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliment : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (this.tag == "Alim")
            {
                GameObject.FindGameObjectWithTag("GlobalCounter").GetComponent<MainScript>().TotalCounter();
            }
            else if (this.tag == "Vida")
            {
                GameObject.FindGameObjectWithTag("GlobalCounter").GetComponent<MainScript>().VidaCounter(this.tag);
            }
            Destroy(gameObject);
        }
    }
}
