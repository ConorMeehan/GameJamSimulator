using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public static AudioManager musicManager;
	
	private GameObject player;
	
	public bool persistAfterLoad = true;
	
	public bool muteMusic = false;

	
	
	
	void Awake()
	{
		if(musicManager == null && persistAfterLoad)
		{
			DontDestroyOnLoad(gameObject);
			musicManager = this;
		}
		else if(musicManager == null && !persistAfterLoad)
		{
			musicManager = this;
		}
		else if (musicManager != this)
		{
			Destroy(gameObject);
		}
		
	}


	public void BecomeDontDestroyOnLoad()
	{
		DontDestroyOnLoad (gameObject);
		musicManager = this;
		persistAfterLoad = true;
	}
	public void BecomeDestroyOnLoad()
	{
		DontDestroyOnLoad (gameObject);
		persistAfterLoad = false;
	}
	public void DestroyThisNow()
	{
		print ("called");
		DestroyImmediate (gameObject);
	}
	
}//Mono