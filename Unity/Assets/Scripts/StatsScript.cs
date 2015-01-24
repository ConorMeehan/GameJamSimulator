using UnityEngine;
using System.Collections;

public class StatsScript : MonoBehaviour {

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
		
		Debug.Log (skillPointsForMe+" = "+ codingSkill+" "+ artSkill+" "+ audioSkill+" "+ writingSkill);
	}

}//end of Mono bracket
