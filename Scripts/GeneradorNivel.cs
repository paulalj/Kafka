using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GeneradorNivel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectWithTag("GlobalCounter").GetComponent<MainScript>().GeneradorTerra(other, this.tag, this.transform.position.x, this.transform.position.z);
    }
}
