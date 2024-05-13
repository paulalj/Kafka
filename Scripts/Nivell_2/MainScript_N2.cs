using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainScript_N2 : MonoBehaviour
{
    public TMP_Text text_vides;

    public int vides = 5;

    private void Update()
    {
        text_vides.text = " " + vides;
    }

    public void VidaCounter(string tag)
    {
        //Ha de treurem una vida, fer soroll i potser inmovilitzarte uns segons

        if (tag == "Vida" && vides < 5)
        {
            vides++;
        }
        else if ((tag == "Ma1") || (tag == "Ma2") || (tag == "Ma3") || (tag == "Ma4") || 
            (tag == "Peu1") || (tag == "Peu2") || (tag == "Peu3") || (tag == "Peu4") ||
            (tag == "Bassall") || (tag == "Enemic"))
        {
            Debug.Log("Vides abans: " + vides);
            vides--;
            Debug.Log("Vides despres: " + vides);
        }
        if (vides == 0)
        {
            Debug.Log("GAME OVER");
            //GameObject.FindGameObjectWithTag("Player").SetActive(false); //Per provar el joc comentar-ho
        }
    }
}
