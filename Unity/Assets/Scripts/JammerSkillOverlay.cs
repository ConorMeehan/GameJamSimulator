using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JammerSkillOverlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var parent = transform.parent.GetComponent<StatsScript>();

		var nameLabels = gameObject.transform.GetChild(0).gameObject.GetComponentsInChildren<Text>();
		foreach(var label in nameLabels)
		{
			if(label.name == "Name")
			{
				label.text = parent.name;
			}
		}

		foreach(var slider in gameObject.GetComponentsInChildren<Slider>())
		{
			float skillLevel = 0;
			switch(slider.name)
			{
			case "Code" :
				skillLevel = parent.codingSkill;
				break;
			case "Audio" :
				skillLevel = parent.audioSkill;
				break;			
			case "Art" :
				skillLevel = parent.artSkill;
				break;			
			case "Writing" :
				skillLevel = parent.writingSkill;
				break;
			}

			slider.value = skillLevel;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
