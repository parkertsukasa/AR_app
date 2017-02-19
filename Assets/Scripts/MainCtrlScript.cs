using UnityEngine;
using System.Collections;

public class MainCtrlScript : MonoBehaviour {

	public GameObject GMsp;

	public GameObject GRes;

	public GameObject death;

	GameObject hpb;
	HPberScript hpbsc;
	GameObject maincam;
	FlashBoardScript FBsc;
	GameObject monit;
	ScoreScript scosc;


	// Use this for initialization
	void Start () {
		GMsp.SetActive (false);
		GRes.SetActive (false);
		hpb = GameObject.Find ("HPber_front");
		hpbsc = hpb.GetComponent<HPberScript> ();
		maincam = GameObject.Find ("Main Camera");
		FBsc = maincam.GetComponent<FlashBoardScript> ();
		monit = GameObject.Find ("Moniter");
		scosc = monit.GetComponent<ScoreScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Dead(){
		GMsp.SetActive (true);
		GRes.SetActive (true);
	}

	public void Restart(){
		GMsp.SetActive (false);
		GRes.SetActive (false);

		death.transform.position = new Vector3 (0.0f, 200.0f, 0.0f);

		hpbsc.HP = 12.0f;
		maincam.transform.position = Vector3.zero;
		FBsc.alive = true;

		Invoke ("DeathReset", 0.1f);
	}

	void DeathReset(){
		death.transform.position = Vector3.zero;
		scosc.score = 0;
	}
}
