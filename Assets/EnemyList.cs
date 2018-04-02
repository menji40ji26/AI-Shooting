using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList : MonoBehaviour {

	public List<GameObject> enemies = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddEnemy(GameObject _enmey){
		enemies.Add(_enmey.gameObject);
	}
}
