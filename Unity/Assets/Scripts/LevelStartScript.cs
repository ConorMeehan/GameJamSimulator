using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelStartScript : MonoBehaviour {

	public GameObject SplashScreenCanvas;

	// Use this for initialization
	void Start () 
	{
		Time.timeScale = 0;
	}

	public void BeginLevel()
	{
		Time.timeScale = 1;
		SplashScreenCanvas.SetActive (false);
	}

	public void Test()
	{
	}

}
