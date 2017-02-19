﻿using UnityEngine;
using System.Collections;

public class WebCameraController : MonoBehaviour {
	public int Width = 1080;
	public int Height = 1920;
	public int FPS = 30;

	public Texture blood;

	void Start () {
		WebCamDevice[] devices = WebCamTexture.devices;
		// display all cameras
		for (var i = 0; i < devices.Length; i++) {
			Debug.Log (devices [i].name);
		}

		WebCamTexture webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
		GetComponent<Renderer> ().material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}

	public void Dead(){
		GetComponent<Renderer> ().material.mainTexture = blood;
	}
}