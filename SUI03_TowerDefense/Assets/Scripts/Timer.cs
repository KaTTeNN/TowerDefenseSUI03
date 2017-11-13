using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    float timer;
    // Use this for initialization
    void Start () {
        timer = 1.0f; //Ändra till valfri antal sekunder
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log("One second has passed"); //Lägg till metod här
            timer = 1.0f; //Sätt till samma värde som timer ovan
        }
    }
}
