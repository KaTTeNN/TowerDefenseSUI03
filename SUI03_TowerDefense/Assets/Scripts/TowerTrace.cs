using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrace : MonoBehaviour {

    public Transform turretTransform;
    public static EnemyScript nearestEnemy;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {

        EnemyScript[] enemies = GameObject.FindObjectsOfType<EnemyScript>();

        nearestEnemy = null;
        float dist = Mathf.Infinity;

        foreach (EnemyScript e in enemies)
        {
            float d = Vector3.Distance(this.transform.position, e.transform.position);
            if(nearestEnemy == null || d < dist)
            {
                nearestEnemy = e;
                dist = d;
            }   
            
        }

        if (nearestEnemy == null)
        {
            Debug.Log("No enemies?");
            return;
        }

        Vector3 dir = nearestEnemy.transform.position - this.transform.position;
        Quaternion lookRot = Quaternion.LookRotation(dir);

        turretTransform.rotation = Quaternion.Euler(0, lookRot.eulerAngles.y, 0);
		
	}
}
