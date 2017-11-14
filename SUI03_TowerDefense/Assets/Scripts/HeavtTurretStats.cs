using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavtTurretStats : Turret
{
    void Start()
    {
        range = 10;
        damage = 10;
        fireRate = 5f;

        costToUpgradeDamage = 100;
        costToUpgradeFireRate = 100;
        costToUpgradeRange = 100;
    }
    
}
