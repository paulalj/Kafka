using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarMenjar : MonoBehaviour
{
    public GameObject Alim1;
    public GameObject Alim2;
    public GameObject Alim3;

    public GameObject vida;

    private GameObject Alim1_nou;
    private GameObject Alim2_nou;
    private GameObject Alim3_nou;

    private Vector3 Alim1_nou_pos = new Vector3(0, 0, 0);
    private Vector3 Alim2_nou_pos = new Vector3(0, 0, 0);
    private Vector3 Alim3_nou_pos = new Vector3(0, 0, 0);

    private Vector3 Alim1_vell_pos = new Vector3(10, 0, 10);
    private Vector3 Alim2_vell_pos = new Vector3(10, 0, 10);
    private Vector3 Alim3_vell_pos = new Vector3(10, 0, 10);

    private Vector3 rotacio = new Vector3(-90f, 0f, 0f);

    private float LastAlim;
    private float lastVida;
    private int rand1;
    private int rand2;
    private int rand3;
    private int aux = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Time.time > LastAlim + 5f 
            && (Math.Abs(Alim1_vell_pos.x - Alim1_nou_pos.x) > 2) 
            && (Math.Abs(Alim1_vell_pos.z - Alim1_nou_pos.z) > 2)
            && (Math.Abs(Alim1_vell_pos.x - Alim2_nou_pos.x) > 2)
            && (Math.Abs(Alim1_vell_pos.z - Alim2_nou_pos.z) > 2)
            && (Math.Abs(Alim1_vell_pos.x - Alim3_nou_pos.x) > 2)
            && (Math.Abs(Alim1_vell_pos.z - Alim3_nou_pos.z) > 2)
            && (Math.Abs(Alim2_vell_pos.x - Alim2_nou_pos.x) > 2) 
            && (Math.Abs(Alim2_vell_pos.z - Alim2_nou_pos.z) > 2)
            && (Math.Abs(Alim2_vell_pos.x - Alim3_nou_pos.x) > 2)
            && (Math.Abs(Alim2_vell_pos.z - Alim3_nou_pos.z) > 2)
            && (Math.Abs(Alim3_vell_pos.x - Alim3_nou_pos.x) > 2)
            && (Math.Abs(Alim3_vell_pos.z - Alim3_nou_pos.z) > 2)
            && aux == 0)
        {

            rand1 = UnityEngine.Random.Range(-10, 10);
            rand2 = UnityEngine.Random.Range(-10, 10);
            rand3 = UnityEngine.Random.Range(-10, 10);

            Vector3 pos1 = new Vector3(this.transform.position.x + rand1, 0.5f, this.transform.position.z + rand1);
            Alim1_nou = Instantiate(Alim1, pos1, Quaternion.identity);

            Vector3 pos2 = new Vector3(this.transform.position.x + rand2, 0.72f, this.transform.position.z + rand2);
            Alim2_nou = Instantiate(Alim2, pos2, Quaternion.identity);

            Vector3 pos3 = new Vector3(this.transform.position.x + rand3, 0.5f, this.transform.position.z + rand3);
            Alim3_nou = Instantiate(Alim3, pos3, Quaternion.identity);

            LastAlim = Time.time;

            Alim1_vell_pos = Alim1_nou_pos;
            Alim2_vell_pos = Alim2_nou_pos;
            Alim3_vell_pos = Alim3_nou_pos;

            Alim1_nou_pos = Alim1_nou.transform.position;
            Alim2_nou_pos = Alim2_nou.transform.position;
            Alim3_nou_pos = Alim3_nou.transform.position;

            aux = 1;
        }

        else if (other.tag == "Player" && Time.time > lastVida + 10f && Time.time % 10 == 0)
        {
            rand1 = UnityEngine.Random.Range(-10, 10);
            Vector3 pos1 = new Vector3(this.transform.position.x + rand1, 0.65f, this.transform.position.z + rand1);
            Instantiate(vida, pos1, Quaternion.Euler(rotacio));
            lastVida = Time.time;
        }
    }
}
