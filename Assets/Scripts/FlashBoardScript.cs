using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FlashBoardScript : MonoBehaviour {

	public GameObject FlashBoard;

	public bool alive;

	GameObject ctrl;
	MainCtrlScript mcsc;

	GameObject monit;
	GhostDestroyScript gdsc;

	public Sprite flight;
	public Sprite sosei;

	public Button FB;

	public AudioSource katya;

	bool canchan;

	bool canfla;

	public Material black;
	public Material white;


	void Start(){

		FlashBoard.gameObject.SetActive (false);

		alive = true;

		canchan = false;
		canfla = true;

		ctrl = GameObject.Find("MainCtrl");
		mcsc = ctrl.GetComponent<MainCtrlScript> ();

		monit = GameObject.Find("Moniter");
		gdsc = monit.GetComponent<GhostDestroyScript> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (alive == true) {
			FB.GetComponent<Image> ().sprite = flight;
		} else {
			FB.GetComponent<Image> ().sprite = sosei;
			Invoke ("canchange", 2.0f);
		}

	}

	public void FlashBoardOn(){

		if (alive == true) {
			if (canfla == true) {
				monit.GetComponent<Renderer> ().material = white;
				katya.Play ();
				canfla = false;
				gdsc.GhostDestroy ();
				Invoke ("FlashBoardOff", 0.3f);
				Invoke ("canflash", 1.5f);
			}
		} else {
			if (canchan == true) {
				mcsc.Restart ();
				canchan = false;
			}
		}
	}

	void canflash(){
		canfla = true;
	}

	void canchange(){
		canchan = true;
	}
		

	void FlashBoardOff(){
		monit.GetComponent<Renderer> ().material = black;
	}
}
