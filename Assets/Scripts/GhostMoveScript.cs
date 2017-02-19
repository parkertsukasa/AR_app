using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GhostMoveScript : MonoBehaviour {

	public float Ghost_Speed;

	public bool cansee;

	GameObject death;

	GameObject mon;

	ScoreScript scrp;

	GameObject hpber;
	HPberScript hpbs;

	// Use this for initialization
	void Start () {
		cansee = false;
		death = GameObject.FindGameObjectWithTag ("Death");
		mon = GameObject.Find ("Moniter");
		scrp = mon.GetComponent<ScoreScript> ();
		hpber = GameObject.Find ("HPber_front");
		hpbs = hpber.GetComponent<HPberScript> ();
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.LookAt (Vector3.zero);

		this.transform.Translate (Vector3.forward * Ghost_Speed);
	

		if (this.transform.position.y >= 100.0f) {
			Destroy (this.gameObject);
			scrp.score_up ();
		}


	}

	public void DieGhost(){
		if (cansee == true) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider tri){
		if (tri.gameObject.tag == "MainCamera") {
			hpbs.Damage ();
			Destroy (this.gameObject);
		}
	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Cansee") {
			cansee = true;
			this.gameObject.transform.parent = death.gameObject.transform;
		}
		if (other.gameObject.tag == "Reset") {
			this.gameObject.transform.parent = death.gameObject.transform;
		}
	}

	void OnTriggerExit(Collider ext){
		if(ext.gameObject.tag == "Cansee"){
			cansee = false;
			this.gameObject.transform.parent = null;
		}
	}



}
