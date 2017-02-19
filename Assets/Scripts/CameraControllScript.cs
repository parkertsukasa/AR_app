using UnityEngine;
using System.Collections;

public class CameraControllScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Input.gyro.enabled = true;
	
		Quaternion devA = Input.gyro.attitude;  //端末のジャイロセンサー値の取得


		//float devAX = devA.x;
		float devAY = devA.y;
		//Kfloat devAZ = devA.z;
		float devAW = devA.w;

		Quaternion dev = new Quaternion(0.0f,-devAY,0.0f,devAW);  //必要な軸の値の取捨

		//Quaternion devS = new Quaternion(devAX,devAY,devAZ,devAW);

		//Vector3 devR = devS.eulerAngles;

		transform.localRotation = dev * Quaternion.Euler(0.0f,1.0f,0.0f);  //回転軸の決定

		//transform.Rotate(devR);

	}
}
