﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    [SerializeField]
    protected float duration;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            StartCoroutine(PickUp(collider));
        }
    }

    protected abstract IEnumerator PickUp(Collider2D collider);
}