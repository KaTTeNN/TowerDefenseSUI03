using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    int playerHealth = 10;

    void OnCollisionEnter(Collision col)
    {
<<<<<<< HEAD
        Debug.Log("This totally worked");
=======
        Debug.Log("I'm here");
>>>>>>> 248ce939129c8e92f52f5abddf8098c83de1d077
        Destroy(col.gameObject);
        playerHealth--;

        if(playerHealth == 0)
        {
            Application.Quit();
        }
    }
}
