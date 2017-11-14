using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    int playerHealth = 10;

    void OnCollisionEnter(Collision col)
    {

        Debug.Log("This totally worked");

        Destroy(col.gameObject);
        playerHealth--;

        if(playerHealth == 0)
        {
            Application.Quit();
        }
    }
}
