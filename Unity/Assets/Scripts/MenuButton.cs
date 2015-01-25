using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour
{
	public void OnMouseUp()
	{
		Application.LoadLevel ("MenuScene");
	}
}
