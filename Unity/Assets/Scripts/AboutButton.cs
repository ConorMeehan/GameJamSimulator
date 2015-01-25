using UnityEngine;
using System.Collections;

public class AboutButton : MonoBehaviour
{
	public void OnMouseUp()
	{
		Application.LoadLevel ("AboutScene");
	}
}
