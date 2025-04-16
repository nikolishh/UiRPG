using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    public Sword()
    {
        weaponName = "Sword";
    }

    public override int GetDamage()
    {
        return 12; // base sword damage
    }
}

