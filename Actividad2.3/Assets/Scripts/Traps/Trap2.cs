using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap2 : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform spawnPoint;
    public float balaSpeed = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DispararBala();
        }
    }

    private void DispararBala()
    {
        GameObject bala = Instantiate(balaPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody balaRigidbody = bala.GetComponent<Rigidbody>();

        Vector3 direccion = spawnPoint.forward;
        balaRigidbody.velocity = direccion * balaSpeed;

        Destroy(bala, 1f);
    }
}