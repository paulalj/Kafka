using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public Canvas canvas_final;

    private void OnTriggerEnter(Collider other)
    {
        canvas_final.gameObject.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").SetActive(false);
    }
}
