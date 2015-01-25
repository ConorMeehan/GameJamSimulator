using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class GameTitleIdeaBuble : MonoBehaviour {

	public float topLevel;

	public UnityEvent onReachedTop;

	bool isFirstUpdate = true;
	public void Update()
	{
		if (isFirstUpdate) {
			isFirstUpdate = false;
			return;
		}
		var worldPos = gameObject.transform.TransformPoint(Vector3.zero);
		if (worldPos.y >= topLevel) {
			if (onReachedTop != null)
				onReachedTop.Invoke();
		}
	}
}
