using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlN2 : MonoBehaviour
{
    public Transform ObjectiuASeguir;
    private float VelocitatCamera = 15f;
    private Vector3 NovaPosicio;

    // Update is called once per frame
    void Update()
    {
        NovaPosicio = this.transform.position;
        NovaPosicio.x = ObjectiuASeguir.transform.position.x + 4;
        NovaPosicio.y = ObjectiuASeguir.transform.position.y + 69;
        NovaPosicio.z = ObjectiuASeguir.transform.position.z - 140;

        // Suavitzat
        this.transform.position = Vector3.Lerp(this.transform.position, NovaPosicio, VelocitatCamera * Time.deltaTime);
    }
}
