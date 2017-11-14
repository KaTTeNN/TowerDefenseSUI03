using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FastTurretStats : Turret
{
    
    void Start()
    {
        range = 10;
        damage = 5;
        fireRate = 10;
        costToUpgradeDamage = 100;
        costToUpgradeFireRate = 100;
        costToUpgradeRange = 100;
    }
    
}
