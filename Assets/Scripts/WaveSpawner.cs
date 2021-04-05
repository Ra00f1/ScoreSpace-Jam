﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
	public enum SpawnState { SPAWNING, WAITING, COUNTING };

	public bool completed = false;

	public GameObject CompletedText;
	public GameObject WaveText;

	[System.Serializable]
	public class Wave
	{
		public string name;
		public Transform[] enemy;
		public int[] count;
		public List<int> count2;
		public float rate;
	}

	public Wave[] waves;
	private int nextWave = 0;
	public int NextWave
	{
		get { return nextWave + 1; }

	}

	public Transform[] spawnPoints;

	public float timeBetweenWaves = 5f;
	private float waveCountdown;
	public float WaveCountdown
	{
		get { return waveCountdown; }
	}

	private float searchCountdown = 1f;

	private SpawnState state = SpawnState.COUNTING;
	public SpawnState State
	{
		get { return state; }
	}

	void Start()
	{
		CompletedText.active = false;
		WaveText.active = false;
		waveCountdown = timeBetweenWaves;
	}

	void Update()
	{
		//if(CompletedAnimator.GetCurrentAnimatorStateInfo.)
		if (state == SpawnState.WAITING)
		{
			if (!EnemyIsAlive())
			{
				WaveCompleted();
				completed = true;
			}
			else
			{
				return;
			}
		}

		if (waveCountdown <= 0)
		{
			if (state != SpawnState.SPAWNING)
			{
				StartCoroutine(SpawnWave(waves[nextWave]));
				completed = false;
			}
		}
		else
		{
			waveCountdown -= Time.deltaTime;
		}
	}

	void WaveCompleted()
	{
		state = SpawnState.COUNTING;
		waveCountdown = timeBetweenWaves;

		if (nextWave + 1 > waves.Length - 1)
		{
			nextWave = 0;
		}
		else
		{
			nextWave++;
		}

		CompletedText.active = true;
		WaveText.active = true;
	}

	bool EnemyIsAlive()
	{
		searchCountdown -= Time.deltaTime;
		if (searchCountdown <= 0f)
		{
			searchCountdown = 1f;
			if (GameObject.FindGameObjectWithTag("Attackers") == null)
			{
				return false;
			}
		}
		return true;
	}

	IEnumerator SpawnWave(Wave _wave)
	{
		state = SpawnState.SPAWNING;

		WaveText.GetComponent<TextMeshProUGUI>().SetText("Wave " + (nextWave + 1));

		for (int i = 0; i < _wave.count.Length; i++)
		{
			int tempenemytype = i;


			for (int x = 0; x < _wave.count[tempenemytype]; x++)
			{
				SpawnEnemy(_wave.enemy[tempenemytype]);
				yield return new WaitForSeconds(1f / _wave.rate);
			}
		}

		state = SpawnState.WAITING;

		yield break;
	}

	void SpawnEnemy(Transform _enemy)
	{
		Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
		Instantiate(_enemy, _sp.position, _sp.rotation);
	}

}