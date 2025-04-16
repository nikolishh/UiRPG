using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public int maxHealth = 80;
    private int currentHealth;
    public int damage = 10;

    public Enemy()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
    }

    public void Attack(Player player)
    {
        player.TakeDamage(damage);
    }

    public bool IsAlive()
    {
        return currentHealth > 0;
    }

    public int GetHealth()
    {
        return currentHealth;
    }
}
