using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyed : MonoBehaviour {

    [SerializeField]
    public float enemyHealth;

    [SerializeField]
    int enemyValue;

	// Update is called once per frame
	void Update ()
    {
		if(enemyHealth <= 0)
        {
            PlayerGold.playerGold += enemyValue;
            Die();
        }
	}

    public void TakeDamage(float damage)
    {
        enemyHealth -= damage;
        Debug.Log(enemyHealth);
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
