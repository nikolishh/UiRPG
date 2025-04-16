using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    public string weaponName;
    public string description;

    public virtual string GetInfo()
    {
        return $"{weaponName}: {description}";
    }

    public abstract int GetDamage(); // must be overridden
}

