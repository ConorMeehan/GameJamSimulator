using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelStartScript : MonoBehaviour {

	public GameObject SplashScreenCanvas;

	// Use this for initialization
	void Start () 
	{
		//Time.timeScale = 0;
	}

	public void BeginLevel()
	{
		print ("test");
		Time.timeScale = 1;
		SplashScreenCanvas.SetActive (false);
	}

	public void Test()
	{
		print ("test 2");
	}

}
