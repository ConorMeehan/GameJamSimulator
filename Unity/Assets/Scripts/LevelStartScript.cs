using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelStartScript : MonoBehaviour {

	public GameObject SplashScreenCanvas;
	public bool levelStarted = false;

	// Use this for initialization
	void Start () 
	{
		Time.timeScale = 0;
		levelStarted = false;
	}

	public void BeginLevel()
	{
		Time.timeScale = 1;
		SplashScreenCanvas.SetActive (false);
		levelStarted = true;
	}

}
