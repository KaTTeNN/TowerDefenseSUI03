using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyed : MonoBehaviour {

    [SerializeField]
    int enemyHealth;

    [SerializeField]
    int enemyValue;

	// Update is called once per frame
	void Update ()
    {
		if(enemyHealth <= 0)
        {
            PlayerGold.playerGold += enemyValue;
            Destroy(gameObject);
        }
	}

    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;
        Debug.Log(enemyHealth);
    }

}
