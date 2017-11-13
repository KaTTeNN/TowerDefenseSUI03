using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

	public enum GameState {Spawning, Waiting, Counting};

	[System.Serializable]
	public class Wave
	{
		public string name;
		public Transform enemy;
		public int count;
		public float rate;
	}

	public Wave[] waves;
	int nextWave = 0; 

	public float timeBetweenWaves = 10f;
	public float waveCountdown;

	private GameState state = GameState.Counting;

	void Start () 
	{
		waveCountdown = timeBetweenWaves;
	}
	

	void Update () 
	{
		if (waveCountdown <= 0) 
		{
			if (state != GameState.Spawning) 
			{
				StartCoroutine (SpawnWave(Wave[nextWave]));
			}
		} 
		else 
		{
			waveCountdown -= Time.deltaTime;
		}
	}

	IEnumerator SpawnWave(Wave wave)
	{
		state = GameState.Spawning;
		for (int i = 0; i < wave.count; i++) 
		{
			EnemySpawning (wave.enemy);
			yield return new WaitForSeconds (1f/wave.rate);
		}
		state = GameState.Waiting;
		yield break;
	}

	public void EnemySpawning(Transform enemy)
	{				
		enemy = Instantiate (enemyPrefab) as GameObject;
		enemy.transform.position = new Vector3 (71, 1, 25);
	}
}
