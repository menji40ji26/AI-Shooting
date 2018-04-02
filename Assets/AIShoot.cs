using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShoot : MonoBehaviour {

	public bool aimed;
	public float shootPower;
	public float shootFreq;
    public float RotateSpeed;
	public float cd;
	public float range;
	public float distance;
	public float currestClosetDis;
	public GameObject bulletPrefab;
	public GameObject shootPoint;
	public Rigidbody rb;
	public EnemyList el;
	public Transform target;

	// Use this for initialization
	void Start () {
		currestClosetDis = range;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		FindTarget();
		Aim(target);
		if(target){
			Shoot();
		}
	}

	void Shoot() {
		cd -= Time.fixedDeltaTime;
		if(cd <= 0) {
			cd = shootFreq;
			GameObject _bulletCopy = Instantiate(bulletPrefab, shootPoint.transform.position, shootPoint.transform.rotation);
			_bulletCopy.GetComponent<BulletFly>().Fly(transform, shootPower);
		}
	}

	void FindTarget(){
		currestClosetDis = range;
		for (int i = 0; i < el.enemies.Count; i++){
			if(CountDis(el.enemies[i].transform) < currestClosetDis){
				target = el.enemies[i].transform;
				currestClosetDis = CountDis(el.enemies[i].transform);
			}
		}
		if(target){
			if(CountDis(target) > range){
				target = null;
			}
		}
	}

	float CountDis(Transform _target){
		distance = Vector3.Distance(transform.position, _target.position );
		return distance;
	}

	void Aim(Transform _target){
		if(_target){
			Vector3 targetDir = target.position - transform.position;

			// The step size is equal to speed times frame time.
			float step = RotateSpeed * Time.deltaTime;

			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
			Debug.DrawRay(transform.position, newDir, Color.red);

			// Move our position a step closer to the target.
			transform.rotation = Quaternion.LookRotation(newDir);
		}
		

	}


}
