using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
public class Camera01 : MonoBehaviour
{
	float t;

	public GameObject x;
	public Camera camMain;
	public bool Skip = false;

	private void Start()
	{
		x.gameObject.SetActive(true);

		camMain.GetComponent<Camera>().enabled = false;
	}

	private void Update()
	{

		if (Skip == true)
		{
			x.gameObject.SetActive(false);
			camMain.GetComponent<Camera>().enabled = true;
		}


	}

	public void ClickButton()
	{
		Skip = true;



	}
}
