using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Weapon
{
    public Axe()
    {
        weaponName = "Axe";
    }

    public override int GetDamage()
    {
        return Random.Range(10, 20);
    }
}

