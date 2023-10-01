using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        if (currentHealth < damage)
        {
            currentHealth = 0;
        }
        else
        {
            currentHealth -= damage;
        }

        healthBar.SetHealth(currentHealth);
    }

    public void Heal(int health)
    {
        currentHealth += health;
        if (currentHealth >= 100)
        {
            currentHealth = 100;
        }

        healthBar.SetHealth(currentHealth);
    }
}