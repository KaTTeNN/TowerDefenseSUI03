using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	[SerializeField] 
	private GameObject enemyPrefab;
	private GameObject enemy;
	float timer;
	float timeBetweenWaves = 10.0f;
	int waveIncrease = 4;
	int waveNumber = 0;

	void start()
	{
		timer = 2.0f; 
	}


	void Update()
	{		
		if (timer <= 0.0f)
		{
			StartCoroutine (WaveSpawning());
			timer = timeBetweenWaves;
		}
		timer -= Time.deltaTime;

	}


	public void EnemySpawning()
	{				
			enemy = Instantiate (enemyPrefab) as GameObject;
			enemy.transform.position = new Vector3 (71, 1, 25);
	}


	IEnumerator WaveSpawning()
	{
		Debug.Log ("New wave incoming");

		waveNumber += waveIncrease;

		for (int i = 0; i < waveNumber; i++) 
		{	
			EnemySpawning ();
			yield return new WaitForSeconds (2.0f);
		}
		if (waveNumber >= 20) {
			Debug.Log ("You won");
		}
			
	}	
}