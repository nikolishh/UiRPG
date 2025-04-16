using UnityEngine;
using UnityEngine.UI;
public class Player
{
    public int maxHealth = 100;
    private int currentHealth;
    public bool shieldActive = false;
    public int shieldDurability = 3;

    public Weapon currentWeapon;

    public Player()
    {
        currentHealth = maxHealth;
    }

    public void ToggleShield()
    {
        shieldActive = !shieldActive;
    }

    public void TakeDamage(int amount)
    {
        if (shieldActive)
        {
            amount /= 2;
            shieldDurability--;

            if (shieldDurability <= 0)
            {
                shieldActive = false;
                shieldDurability = 0;
            }
        }

        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }

    /*public void Attack(Enemy enemy)
    {
        int totalDamage = currentWeapon != null ? currentWeapon.GetDamage() : 10;
        enemy.TakeDamage(totalDamage);
    }*/

    public int GetHealth()
    {
        return currentHealth;
    }

    public bool IsAlive()
    {
        return currentHealth > 0;
    }
}


