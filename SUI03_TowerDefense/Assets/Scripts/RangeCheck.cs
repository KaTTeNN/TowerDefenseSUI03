using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeCheck : MonoBehaviour {

    public Transform target;
    public float distanceBetweenThem;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(target != null)
            distanceBetweenThem = Vector3.Distance(target.position, transform.position);

    }
}
