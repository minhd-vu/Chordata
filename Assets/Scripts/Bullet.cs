﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float range;
    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(initialPosition, transform.position) > range)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
}