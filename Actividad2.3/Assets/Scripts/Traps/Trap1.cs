using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1 : MonoBehaviour
{
    public float speed;

    private float initialY;

    private void Start()
    {
        initialY = transform.position.y;
    }

    private void Update()
    {
        float newY = initialY + Mathf.Sin(Time.time * speed);

        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
