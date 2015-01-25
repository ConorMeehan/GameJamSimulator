using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level1Manager : MonoBehaviour {

	public int membersOnTeam;
	int maxMembers;

	public GameObject nextLevelButton;

	// Use this for initialization
	void Start () 
	{
		maxMembers = TeamScript.teamScript.maxMembersOnTeam;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.T))
		{
			LoadNextLevel();
		}

		membersOnTeam = TeamScript.teamScript.teamMemberList.Count;

		if(membersOnTeam == maxMembers)
		{
			Level1Complete();
		}
	}

	void Level1Complete()
	{
		Time.timeScale = 0; //will this stop the next level button appearing? or accepting clicks?
		nextLevelButton.SetActive (true);

		GameObject[] allJammers = GameObject.FindGameObjectsWithTag("Jammer");

		foreach (GameObject jammer in allJammers) 
		{
			if(jammer.transform.parent.name == "Jammers")
			{
				jammer.GetComponent<CircleCollider2D>().enabled = false;
			}
		}
	}

	public void LoadNextLevel()
	{
		//Application.LoadLevel("testScene-Kevin");
		Application.LoadLevel("2-PICK YOUR GAME");
	}
}
