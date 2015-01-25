using UnityEngine;
using System.Collections;

public class Level2Manager : MonoBehaviour {

	public Vector2[] seatsAtTable;

	// Use this for initialization
	void Start () 
	{
		SetTeamsCharacteristics ();
	}

	void SetTeamsCharacteristics()
	{
		GameObject[] allTeamMembers = GameObject.FindGameObjectsWithTag ("Jammer");
		int i = 0;

		foreach(GameObject jammer in allTeamMembers)
		{
			GameObject childCanvas = jammer.transform.FindChild("JammerOverlay").gameObject;
			Destroy(childCanvas);

			GameObject otherChildCanvas = jammer.transform.FindChild("Tick Canvas").gameObject;
			Destroy(otherChildCanvas);

			jammer.transform.position = seatsAtTable[i];
			i++;
		}
	}

	public void LoadLevel3()
	{
		Application.LoadLevel ("3-FINISH YOUR GAME");
	}
}
