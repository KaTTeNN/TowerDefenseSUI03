using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGetDamage
{
    int GetDamage();
}

public class Damage : MonoBehaviour
{
    Turret temp;
    int dam;

    // Detta borde funka så länge man lägger till detta i i de olika sorter bullets och de kolliderar med motståndarna.
    void Start()
    {
        temp = gameObject.GetComponentInParent<Turret>();
        //dam = temp.GetDamage(); Lägg till när kod för att kulan skapas är klar
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemies")
        {
            dam = temp.GetDamage(); //Ta bort när kod för att kulan skapas är klar
            Destroy(gameObject);
            EnemyScript sak = col.gameObject.GetComponent<EnemyScript>();;
            sak.TakeDamage(dam);
        }
    }
}
