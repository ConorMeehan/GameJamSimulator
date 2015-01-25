using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour
{
	public void OnMouseUp()
	{
		Application.LoadLevel ("1-PICK YOUR TEAM");
	}
}
