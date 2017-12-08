using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class intro : MonoBehaviour {
	public float x;
	public float time = 0.0f;

	[SerializeField]
	Camera camMain;

	[SerializeField]
	Camera camWelcome;

	[SerializeField]
	GameObject canvaButtons;

	[SerializeField]
	Canvas canvaUvod;



	void Start()
	{


		camMain.GetComponent<Camera>().enabled = false;
		camWelcome.GetComponent<Camera>().enabled = true;
		canvaButtons.gameObject.SetActive(false);
		canvaUvod.GetComponent<Canvas>().enabled = true;



	}


	private void Update()
	{
		time += Time.deltaTime;



		if (time >= x)
		{
			camMain.GetComponent<Camera>().enabled = true;
			camWelcome.GetComponent<Camera>().enabled = false;

			canvaButtons.gameObject.SetActive(true);
			canvaUvod.GetComponent<Canvas>().enabled = false;




		}


	}
}
