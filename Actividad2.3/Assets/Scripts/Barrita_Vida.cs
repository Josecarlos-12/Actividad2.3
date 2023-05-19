using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barrita_Vida : MonoBehaviour
{
    public float vida = 100;
    public float vida_max = 100;

    public Image Barradevida;

    public Text TextoVida;
    void Update()
    {
        Acinterface();
    }

    void Acinterface()
    {
        Barradevida.fillAmount = vida / vida_max;
        TextoVida.text = "Vida: " + vida.ToString("f0");
    }

    public void recibircura( float cura)
    {
        vida += cura;

        if (vida > vida_max)
        {
            vida = vida_max;
        }
    }
}
