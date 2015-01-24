using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using UnityEngine.UI;

public class StatsScript : MonoBehaviour {

	public char gender = 'm';

	public float codingSkill;
	public float artSkill;
	public float audioSkill;
	public float writingSkill;

	float minimumSkillPoints = 60;
	float maximumSkillPoints = 90;

	float skillPointsForMe = 60f; //just a default value
	float skillPointsLeftToAssign;


	void Start () 
	{
		SetStatsAtBeginning ();
		
		if( Random.Range(0,1) < 1 )
		{
			gender = 'f';
		}

		NameGenerator ng = NameGenerator.Instance;
		name = ng.getRandomName(gender);
	}

	void SetStatsAtBeginning()
	{
		skillPointsForMe = Random.Range (minimumSkillPoints, maximumSkillPoints);
		skillPointsLeftToAssign = skillPointsForMe;
		
		codingSkill = Random.Range (0, skillPointsLeftToAssign); //first skill roll
		skillPointsLeftToAssign -= codingSkill; //reduce points left to assign
		
		artSkill = Random.Range (0, skillPointsLeftToAssign);
		skillPointsLeftToAssign -= artSkill;
		
		audioSkill = Random.Range (0, skillPointsLeftToAssign);
		skillPointsLeftToAssign -= audioSkill;
		
		writingSkill = skillPointsLeftToAssign; //gets whatever's left

	}

	void OnMouseDown()
	{
		print ("Hi! My Skills are: "+skillPointsForMe+" = "+ codingSkill+" "+ artSkill+" "+ audioSkill+" "+ writingSkill);
		gameObject.transform.GetChild(0).gameObject.SetActive(!gameObject.transform.GetChild(0).gameObject.activeSelf);
	}

	public void AddToTeam()
	{
		//add to TEAM GameObject
	}

	public void NoThanks()
	{
		//close the UI box
	}
}//end of Mono bracket
