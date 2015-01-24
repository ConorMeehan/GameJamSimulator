using UnityEngine;
using System.Collections;

public class ButtonClickScript : MonoBehaviour {

	public GameObject SplashScreenCanvas;


	void Start()
	{
		//Time.timeScale = 0;
	}

	void OnMouseDown()
	{
		Time.timeScale = 1;
		SplashScreenCanvas.SetActive (false);
		print ("test me");
	}

}
