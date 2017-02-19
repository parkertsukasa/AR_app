using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text score_text;

	public int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (score);
		score_text.text = "得点:" + score.ToString ();
	}

	public void score_up(){
		score += 100;
	}
}
