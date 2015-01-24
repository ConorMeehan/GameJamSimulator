﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TeamScript : MonoBehaviour {

	public static TeamScript teamScript;

	public List<GameObject> teamMemberList;

	public Slider codeSkillSlider;
	public Slider artSkillSlider;
	public Slider audioSkillSlider;
	public Slider writingSkillSlider;


	void Awake()
	{
		//this code makes the timer a Singleton. You can place it in any scene and it'll persist into the next
		//scene without creating two timers (like if the next scene were to have another timer in it)
		if(teamScript == null)
		{
			DontDestroyOnLoad(gameObject);
			teamScript = this;
		}
		else if (teamScript != this)
		{
			Destroy(gameObject);
		}
		//end of Singleton
	}

	void Start()
	{
		UpdateSLider ();
	}

	public void AddTeamMember(GameObject member)
	{
		member.transform.SetParent (this.gameObject.transform);
		teamMemberList.Add (member);
		UpdateSLider ();
	}

	public void UpdateSLider()
	{
		float artSkillTotal = 0;
		float audioSkillTotal = 0;
		float codingSkillTotal = 0;
		float writingSkillTotal = 0;

		var numberOfTeamMembers = teamMemberList.Count; 

		foreach (GameObject name in teamMemberList) 
		{

			StatsScript temp = name.GetComponent<StatsScript> ();
			artSkillTotal += temp.artSkill;
			audioSkillTotal += temp.audioSkill;
			codingSkillTotal += temp.codingSkill;
			writingSkillTotal += temp.writingSkill;
		}

		codeSkillSlider.value = codingSkillTotal/2f;
		artSkillSlider.value = artSkillTotal/2f;
		audioSkillSlider.value = audioSkillTotal/2f;
		writingSkillSlider.value = writingSkillTotal/2f;


	}

}
