using UnityEngine;
using System.Collections;

public class GetTitleIdeaBuble : MonoBehaviour {

	//this game object's transform  
	private Transform goTransform;  
	//the game object's position on the screen, in pixels  
	private Vector3 goScreenPos;  
	//the game objects position on the screen  
	private Vector3 goViewportPos;  
	
	//the width of the speech bubble  
	public int bubbleWidth = 200;  
	//the height of the speech bubble  
	public int bubbleHeight = 100;  
	
	//an offset, to better position the bubble  
	public float offsetX = 0;  
	public float offsetY = 0;  
	
	//an offset to center the bubble  
	private int centerOffsetX;  
	private int centerOffsetY;  
	
	private float animationProgress;
	public float AnimationProgress {
		get{ return animationProgress; }
		set{ animationProgress = value;}
	}
	
	//use this for early initialization  
	void Awake ()  
	{  
		//get this game object's transform  
		goTransform = this.GetComponent<Transform>();  
	}  
	
	//use this for initialization  
	void Start()  
	{  

		
		//Calculate the X and Y offsets to center the speech balloon exactly on the center of the game object  
		centerOffsetX = bubbleWidth/2;  
		centerOffsetY = bubbleHeight/2;  
	}  
	
	//Called once per frame, after the update  
	void LateUpdate()  
	{  
		//find out the position on the screen of this game object  
		goScreenPos = Camera.main.WorldToScreenPoint(goTransform.position);   
		
		//Could have used the following line, instead of lines 70 and 71  
		//goViewportPos = Camera.main.WorldToViewportPoint(goTransform.position);  
		goViewportPos.x = goScreenPos.x/(float)Screen.width;  
		goViewportPos.y = goScreenPos.y/(float)Screen.height;  
	}  
	
	//Draw GUIs  
	void OnGUI()  
	{  
		//Begin the GUI group centering the speech bubble at the same position of this game object. After that, apply the offset  
		GUI.BeginGroup(new Rect(goScreenPos.x-centerOffsetX-offsetX,Screen.height-goScreenPos.y-centerOffsetY-offsetY,bubbleWidth,bubbleHeight));  
		
		//Render the round part of the bubble  
		//GUI.Label(new Rect(0,0,200,100),"",guiSkin.customStyles[0]);  
		
		//Render the text  
		//GUI.Label(new Rect(10,25,190,50),"You can add any GUI element here, like the button below:",guiSkin.label);  
		
		//If the button is pressed, go back to 41 Post  
		if(GUI.Button(new Rect(0,0,bubbleWidth,bubbleHeight),"Back to post..."))  
		{  
			Destroy(this.gameObject);
		}  
		
		GUI.EndGroup();  
	}  
	

}
