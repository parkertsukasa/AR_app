using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HPberScript : MonoBehaviour {

	public float HP;

	GameObject ctrl;
	MainCtrlScript mcsc;

	GameObject flabut;
	FlashBoardScript fbsc;

	// Use this for initialization
	void Start () {
		HP = 12.0f;
		ctrl = GameObject.Find("MainCtrl");
		mcsc = ctrl.GetComponent<MainCtrlScript> ();

		flabut = GameObject.Find("Main Camera");
		fbsc = flabut.GetComponent<FlashBoardScript> ();
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.localScale = new Vector2 (HP * 0.75f, 0.9f);

		if (HP <= 0.0f) {
			mcsc.Dead ();
			fbsc.alive = false;
			flabut.transform.position = new Vector3 (0.0f, 200.0f, 0.0f);
		}
	}
		
	public void Damage(){
		HP -= 1.0f;
	}
}
