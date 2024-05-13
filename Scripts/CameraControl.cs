using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform ObjectiuASeguir;
    private float VelocitatCamera = 15f;
    private Vector3 NovaPosicio;

    // Update is called once per frame
    void Update()
    {
        NovaPosicio = this.transform.position;
        NovaPosicio.x = ObjectiuASeguir.transform.position.x;
        NovaPosicio.z = ObjectiuASeguir.transform.position.z;

        // Suavitzat
        this.transform.position = Vector3.Lerp(this.transform.position, NovaPosicio, VelocitatCamera * Time.deltaTime);
    }
}
