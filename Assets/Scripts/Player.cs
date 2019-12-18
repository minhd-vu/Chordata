﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float _health;
    public float health
    {
        get { return _health; }
        set
        {
            _health = value;
            if (_health > maxHealth)
            {
                _health = maxHealth;
            }
        }
    }
    public float maxHealth;
    [SerializeField]
    private float healthPerSecond;
    [HideInInspector]
    public float healthPerSecondBonus;
    private float regenTimer;
    [SerializeField]
    private float regenTime;
    [SerializeField]
    private Image healthBar;
    [SerializeField]
    private GameObject damageParticles;

    [HideInInspector]
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        regenTimer = 0f;
        healthPerSecondBonus = 0f;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((regenTimer += Time.deltaTime) >= regenTime)
        {
            health += healthPerSecond + healthPerSecondBonus;
            regenTimer = 0f;
        }

        // Update the health bar.
        healthBar.fillAmount = health;
    }

    /**
     * Deal damage to the player
     */
    public void damage(float damage)
    {
        health -= damage;
        Instantiate(damageParticles, transform);
    }
}
