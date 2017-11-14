using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

  
    public enum GameState {Spawning, Waiting, Counting};

	[System.Serializable]
	public class Wave
	{

        public Transform enemy;
        public string name;
		public int count;
		public float rate;
	}

	public Wave[] waves;
	int nextWave = 0; 

	public float timeBetweenWaves = 5f;
	public float waveCountdown;

    private float searchCountdown = 1f;

	private GameState state = GameState.Counting;

	void Start () 
	{
		waveCountdown = timeBetweenWaves;
	}
	

	void Update () 
	{

        if (state == GameState.Waiting)
        {
            if (!EnemyIsAlive())
            {
                return;
            }
            else
            {
                return;
            }
        }
		if (waveCountdown <= 0) 
		{
			if (state != GameState.Spawning) 
			{
				StartCoroutine (SpawnWave(waves[nextWave]));
			}
		} 
		else 
		{
			waveCountdown -= Time.deltaTime;
		}
	}

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }

	IEnumerator SpawnWave(Wave _wave)
	{
		state = GameState.Spawning;
		for (int i = 0; i < _wave.count; i++) 
		{
            EnemySpawning(_wave.enemy);
			yield return new WaitForSeconds (1f/_wave.rate);
		}
		state = GameState.Waiting;
		yield break;
	}

	void EnemySpawning(Transform _enemy)
	{       
        transform.position = new Vector3(71, 1, 25);
        Instantiate(_enemy, transform.position, transform.rotation);
    }

    void WaveCompleted()
    {
        Debug.Log("Wave Completed");

        state = GameState.Counting;
        waveCountdown = timeBetweenWaves;
        if (nextWave+1 > waves.Length-1)
        {
            // Lägga till en "Game finished screen!!!!!"
            nextWave = 0;
            Debug.Log("You have completed all the waves, The game will as of now start over");
        }
        else
        {
            nextWave++;
        }
    }
}
