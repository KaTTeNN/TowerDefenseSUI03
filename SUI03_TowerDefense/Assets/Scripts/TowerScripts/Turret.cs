using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour, IGetDamage
{
    public int range, damage;
    public float fireRate;
    public int costToUpgradeRange, costToUpgradeFireRate, costToUpgradeDamage;

    public void AddDamage(int damageAdd)
    {
        
        if (PlayerGold.playerGold >= costToUpgradeDamage)
        {
            damage += damageAdd;
            PlayerGold.playerGold -= costToUpgradeDamage;
            costToUpgradeDamage *= 2;
            Debug.Log("You have " + PlayerGold.playerGold + " gold left");
            Debug.Log(damage);
        }
        else
            Debug.Log("You can't afford that");
    }

    public int GetDamage()
    {
        return damage;
    }

    public void AddFireRate(int fireRateAdd)
    {
        if (PlayerGold.playerGold >= costToUpgradeFireRate)
        {
            fireRate += fireRateAdd;
            PlayerGold.playerGold -= costToUpgradeFireRate;
            costToUpgradeFireRate *= 2;
            Debug.Log("You have " + PlayerGold.playerGold + " gold left");
            Debug.Log(fireRate);
        }
        else
            Debug.Log("You can't afford that");

    }

    public void AddRange(int rangeAdd)
    {
        if (PlayerGold.playerGold >= costToUpgradeRange)
        {
            range += rangeAdd;
            PlayerGold.playerGold -= costToUpgradeRange;
            costToUpgradeRange *= 2;
            Debug.Log("You have " + PlayerGold.playerGold + " gold left");
            Debug.Log(range);
        }
        else
            Debug.Log("You can't afford that");
    }

    public static GameObject chosenTurret;

    void OnMouseUpAsButton()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit)
        {
            if (hitInfo.transform.gameObject.tag == "Turret")
            {
                chosenTurret = hitInfo.transform.gameObject;
            }

            else
            {
                chosenTurret = null;
            }
        }

    }
}
