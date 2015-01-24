using UnityEngine;
using System.Collections;

public class Level1Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.T))
		{
			Application.LoadLevel("testScene-Kevin");
		}
	}
}
