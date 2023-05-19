using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curacion : MonoBehaviour
{
    public float curame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& other.GetComponent<Barrita_Vida>())
        {
            other.GetComponent<Barrita_Vida>().recibircura(curame);

            Destroy(gameObject);
        }
    }
}
