using UnityEngine;
using System.Collections;

public class RandomiseJammer : MonoBehaviour
{
	void Start ()
	{
		Color random = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
		GetComponent<SpriteRenderer> ().color = random;

		Quaternion rotation = Quaternion.Euler (0, 0, Random.Range (0, 180f));
		gameObject.transform.localRotation = rotation;
	}
}
