using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	public float speed;	
	void Start(){
		Destroy(this.gameObject, 15);
	}
	
	public void Move () {
		GetComponent<Rigidbody>().AddForce(transform.forward * speed * 100f );
	}
}
