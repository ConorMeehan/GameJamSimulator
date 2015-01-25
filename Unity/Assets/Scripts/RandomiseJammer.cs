using UnityEngine;
using System.Collections;

public class RandomiseJammer : MonoBehaviour
{
	void Start ()
	{
		Color random = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
		GetComponent<SpriteRenderer> ().color = random;
	}
}
