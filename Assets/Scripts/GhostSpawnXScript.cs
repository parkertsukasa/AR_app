﻿using UnityEngine;
using System.Collections;

public class GhostSpawnXScript : MonoBehaviour {

	float Timer = 0.0f;

	public float Inter;

	public GameObject Ghost;

	public float min_itr;
	public float max_itr;


	// Use this for initialization
	void Start () {

		Inter = Random.Range(min_itr,max_itr);

	}
	
	// Update is called once per frame
	void Update () {
	
		Timer += Time.deltaTime;


		if (Timer >= Inter) {
			Instantiate (Ghost,new Vector3(this.transform.position.x + Random.Range(-200.0f,200.0f),this.transform.position.y,this.transform.position.z),Quaternion.identity);
			Timer = 0.0f;
			Inter = Random.Range(min_itr,max_itr);
		}


		this.transform.LookAt (Vector3.zero);

	}
}