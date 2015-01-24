using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProjectIdeasStats : MonoBehaviour {

	public Text projectTitle;
	public Slider codingDifficultySlider; //use this followed by ".value" to alter the values
	public Slider artDifficultySlider;
	public Slider audioDifficultySlider;
	public Slider writingDifficultySlider;

	public string projectName;
	public float codingDifficulty; //set this in the Inspector for each case. We're doing it manually
	public float artDifficulty;
	public float audioDifficulty;
	public float writingDifficulty;


	// Use this for initialization
	void Start () 
	{
		projectTitle.text = projectName;
		codingDifficultySlider.value = codingDifficulty;
		artDifficultySlider.value = artDifficulty;
		audioDifficultySlider.value = audioDifficulty;
		writingDifficultySlider.value = writingDifficulty;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
