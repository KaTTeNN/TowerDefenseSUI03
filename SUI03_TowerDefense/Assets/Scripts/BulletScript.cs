using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public static Transform target;
    public float speed;
    float timer;

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (target != null)
            Shoot(step);

    }

    void Shoot(float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
    }
}
