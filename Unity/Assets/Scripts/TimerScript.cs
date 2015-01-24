using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerScript : MonoBehaviour {

	public static TimerScript timerScript;

	public float timeRemainingAtSceneStart = 2880f; //In Hours. can set in Inspector for testing your scene starting from
	//a specific time. Don't change here. Change in  editor.

	public float timePassingRate = 16f; //to pass 48hrs (2880 mins) in 3real-world mins, set this to 16, 
	// Unity measures time in seconds. Don't change here. Change in  editor.

	[HideInInspector]
	public float timeRemaining; //the time that'll be displayed on the clock. don't need to edit

	public Text timerText;
	private string timerTextString;

	public Slider timeSlider;

	void Awake()
	{
		//this code makes the timer a Singleton. You can place it in any scene and it'll persist into the next
		//scene without creating two timers (like if the next scene were to have another timer in it)
		if(timerScript == null)
		{
			DontDestroyOnLoad(gameObject);
			timerScript = this;
		}
		else if (timerScript != this)
		{
			Destroy(gameObject);
		}
		//end of Singleton
	}

	// Use this for initialization
	void Start () 
	{
		timeRemaining = timeRemainingAtSceneStart * 60 * 60; //converting hours into seconds for Unity
		timeSlider.direction = Slider.Direction.LeftToRight;
		timeSlider.maxValue = timeRemaining;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//countdown
		timeRemaining = timeRemaining - (Time.deltaTime*timePassingRate*60);
		timerTextString = ((timeRemaining / 3600).ToString("F"));//
		timerText.text = timerTextString + " hrs";
		if (timeSlider != null)
		{
			timeSlider.value = timeRemaining;
		}
	}
}//end of MonoBehaviour bracket