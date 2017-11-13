using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeCheck : MonoBehaviour {
    
    public GameObject Tower;
    public GameObject Enemie;
    public float distanceBetweenThem;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        distanceBetweenThem = Vector3.Distance(Tower.transform.position, Enemie.transform.position);

        Debug.Log("Distance between obj1 and obj2 is " + distanceBetweenThem);

    }
}
