using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : Weapon
{
    public Staff()
    {
        weaponName = "Staff";
    }

    public override int GetDamage()
    {
        int baseDamage = 8;
        if (Random.value < 0.25f) // 25% crit
            baseDamage += 10;

        return baseDamage;
    }
}

