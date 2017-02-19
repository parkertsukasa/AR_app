using UnityEngine;
using System.Collections;

public class GhostDestroyScript : MonoBehaviour {

	public GameObject ghost_pref;

	public GameObject death;

	//GhostMoveScript gms;


	// Use this for initialization
	void Start () {
		death = GameObject.FindGameObjectWithTag("Death");

	}

	void Update () {
	}
		
	public void GhostDestroy(){
		death.transform.position = new Vector3 (0.0f, 200.0f, 0.0f);
		Invoke ("deathposres", 0.1f);

	}

	void deathposres(){
		death.transform.position = Vector3.zero;
	}
}
