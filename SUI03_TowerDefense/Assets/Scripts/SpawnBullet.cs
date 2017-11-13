using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour {

    public Transform bulletPosition;
    public GameObject bullet;
    float timer;

    // Use this for initialization
    void Start () {
        timer = 1f;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = 1f;
            Instantiate(bullet, bulletPosition.transform);
            BulletTravel.target = ; // Closest target.
        }

    }
}
