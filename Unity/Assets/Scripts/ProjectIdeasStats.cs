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

	public GameObject nextLevelButton;

	public void UpdateProperties()
	{
		projectTitle.text = projectName;
		codingDifficultySlider.value = codingDifficulty;
		artDifficultySlider.value = artDifficulty;
		audioDifficultySlider.value = audioDifficulty;
		writingDifficultySlider.value = writingDifficulty;
	}

	// Use this for initialization
	void Start () 
	{
		UpdateProperties ();
	}

	// for if this is the project the player chooses by letting it reach the finish line
	public void WinRound2Function()
	{
		//DontDestroyOnLoad (this.gameObject);

		transform.localPosition = new Vector2 (1f, -4.2f); //to move this to the bottom right of screen for round 3

		//GetComponent<Animator> ().enabled = false; //to stop the animator happening

		Time.timeScale = 0;

		nextLevelButton = GameObject.FindGameObjectWithTag ("NextLevelButton");
		print (nextLevelButton);
		nextLevelButton.transform.FindChild ("NextLevel Button").gameObject.SetActive (true);
		nextLevelButton.SetActive (true);
	}


}
