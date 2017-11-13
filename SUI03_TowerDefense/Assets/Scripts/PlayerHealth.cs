using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    int playerHealth = 10;

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        playerHealth--;

        if(playerHealth == 0)
        {
            Application.Quit();
        }
    }
}
