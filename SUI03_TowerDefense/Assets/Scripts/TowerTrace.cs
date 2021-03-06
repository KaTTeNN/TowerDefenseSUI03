﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrace : MonoBehaviour {


    Transform turretTransform;
    float range = 50f;
    public GameObject bulletPrefab;
    float fireCooldown = 3f;
    float fireCooldownLeft = 0;

	void Start () {
       turretTransform = transform.Find("Tower_Pivot");
	}

	void Update ()
    {



        EnemyDestroyed[] enemies = GameObject.FindObjectsOfType<EnemyDestroyed>();


       EnemyDestroyed nearestEnemy = null;
        float dist = Mathf.Infinity;

        foreach (EnemyDestroyed e in enemies)
        
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

        fireCooldownLeft -= Time.deltaTime;
        if(fireCooldownLeft <= 0 && dir.magnitude <= range)
        {
            fireCooldownLeft = fireCooldown;
            ShootAt(nearestEnemy);
        }
	}
    void ShootAt(EnemyDestroyed e)
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);

        Bullet b = bulletGO.GetComponent<Bullet>();
        b.target = e.transform;
    }
	
	}

