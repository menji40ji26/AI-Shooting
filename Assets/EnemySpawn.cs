using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	public float spawnFreq;
	public float cd;
	public GameObject enemyPrefab;
	public GameObject enemyList;


	// Use this for initialization
	void Start () {
		enemyList = GameObject.Find("EnemyList");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
			Spawn();
	}

	void Spawn() {
		cd -= Time.fixedDeltaTime;
		if(cd <= 0) {
			print("Shoot");
			cd = spawnFreq;
			Vector3 _spawnPoint = new Vector3 (
				Random.Range(-10, 10) + transform.position.x , 
				Random.Range(-1, 1) + transform.position.y ,
				transform.position.z );
			GameObject _enemyCopy = Instantiate(enemyPrefab, _spawnPoint, transform.rotation);
			_enemyCopy.GetComponent<EnemyMove>().Move();
			_enemyCopy.transform.SetParent(enemyList.transform);
			enemyList.GetComponent<EnemyList>().AddEnemy(_enemyCopy);
		}
	}
}
