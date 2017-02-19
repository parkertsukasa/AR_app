using UnityEngine;
using System.Collections;

public class Camera_ProvisScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.transform.localRotation = Quaternion.identity;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (new Vector3 (0.0f,10.0f,0.0f));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (new Vector3 (0.0f,-10.0f,0.0f));
		}
	}
}
