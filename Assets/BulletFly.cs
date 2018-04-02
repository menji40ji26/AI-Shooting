using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour {

	public float errorRange;
	
	void Start(){
		Destroy(this.gameObject, 3);
	}

	public void Fly (Transform shootPoint, float _speed) {
		Vector3 _direction = new Vector3(
			Random.Range(shootPoint.forward.x - errorRange,shootPoint.forward.x + errorRange ),
			Random.Range(shootPoint.forward.y - errorRange,shootPoint.forward.y + errorRange ),
			Random.Range(shootPoint.forward.z - errorRange,shootPoint.forward.z + errorRange ));
		GetComponent<Rigidbody>().AddForce(_direction * _speed * 100f );
	}

	void  OnCollisionEnter(Collision _other){
		if(_other.gameObject.CompareTag("Enemy")){
			print("Killed");
			_other.gameObject.GetComponent<EnemyDie>().Die();
		}
	}
}
