using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour {


	public void Die(){
		EnemyList _el = GameObject.Find("EnemyList").GetComponent<EnemyList>();
		for (int i = 0; i < _el.enemies.Count; i++){
			if(_el.enemies[i] == this.gameObject){
				_el.enemies.RemoveAt(i);
			}
		}
		Destroy(this.gameObject, 0.1f);
	}
}
