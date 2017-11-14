using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    int playerHealth = 10;

    void OnCollisionEnter(Collision col)
    {
<<<<<<< HEAD
<<<<<<< HEAD

        Debug.Log("This totally worked");

=======
>>>>>>> parent of 8d07418... Semi-working waves
=======
>>>>>>> parent of 8d07418... Semi-working waves
        Destroy(col.gameObject);
        playerHealth--;

        if(playerHealth == 0)
        {
            Application.Quit();
        }
    }
}
