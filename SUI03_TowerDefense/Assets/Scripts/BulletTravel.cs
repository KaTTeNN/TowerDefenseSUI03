using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTravel : MonoBehaviour {

    public static Transform target;
    public float speed;

	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        if(target != null)
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

	}
}
