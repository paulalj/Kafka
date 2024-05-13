using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainScript : MonoBehaviour
{
    public int GB;
    public int vida;

    public GameObject terra;

    public TMP_Text text_vides;
    public Canvas canvas_anim1;

    private Vector3 terra_pos = Vector3.zero;

    private GameObject terra_vell;
    private GameObject terra_nou;

    private void Start()
    {
        GB = 0;
        vida = 5;
        terra_vell = Instantiate(terra, terra_pos, Quaternion.identity);
    }

    private void Update()
    {
        text_vides.text = " " + vida;
    }

    public void TotalCounter()
    {
        GB++;

        if (GB == 30)
        {
            canvas_anim1.gameObject.SetActive(true);
        }
    }

    public void VidaCounter(string tag)
    {
        //Ha de treurem una vida, fer soroll i potser inmovilitzarte uns segons

        if (tag == "Vida" && vida < 5)
        {
            vida++;
        }
        else if (tag == "Enemic")
        {
            vida--;
        }
        else if (vida == 0)
        {
            GameObject.FindGameObjectWithTag("Player").SetActive(false); //Per provar el joc comentar-ho
        }
    }

    public void GeneradorTerra(Collider other, string tag, float pos_x, float pos_z)
    {
        if (other.tag == "Player" && tag == "Dreta")
        {
            Vector3 pos_dreta = new Vector3(pos_x + 5, 0, pos_z);
            terra_nou = Instantiate(terra, pos_dreta, Quaternion.identity);

            Destroy(terra_vell);
            terra_vell = terra_nou;
        }

        else if (other.tag == "Player" && tag == "Esquerra")
        {
            Vector3 pos_esquerra = new Vector3(pos_x - 5, 0, pos_z);
            terra_nou = Instantiate(terra, pos_esquerra, Quaternion.identity);

            Destroy(terra_vell);
            terra_vell = terra_nou;
        }

        else if (other.tag == "Player" && tag == "Adalt")
        {
            Vector3 pos_adalt = new Vector3(pos_x, 0, pos_z + 5);
            terra_nou = Instantiate(terra, pos_adalt, Quaternion.identity);

            Destroy(terra_vell);
            terra_vell = terra_nou;
        }

        else if (other.tag == "Player" && tag == "Abaix")
        {
            Vector3 pos_abaix = new Vector3(pos_x, 0, pos_z - 5);
            terra_nou = Instantiate(terra, pos_abaix, Quaternion.identity);

            Destroy(terra_vell);
            terra_vell = terra_nou;
        }
    }
}
