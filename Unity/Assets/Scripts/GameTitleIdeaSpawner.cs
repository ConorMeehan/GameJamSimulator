using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameTitleIdeaSpawner : MonoBehaviour {

	private float spawnTime = 8.0f+(RandomGenerator.Next() % 100)/40.0f;		// The amount of time between each spawn.
	private float spawnDelay = 3.0f;		// The amount of time before spawning starts.
	public GameObject prefab;		// Array of enemy prefabs.
	public GameObject destroyerScript;		// Array of enemy prefabs.

	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}

	void Spawn ()
	{
		// Instantiate a random enemy.
		var obj = (GameObject)Instantiate (prefab);//, transform.position, transform.rotation);
		var title = GameTitleGenerator.Generate ();
		obj.transform.parent = this.gameObject.transform;

		var buttons = obj.GetComponentsInChildren <Button>(true);
		if (buttons != null) {
			foreach (Button button in buttons)
			{
				button.onClick.AddListener (() => {
					Destroy (obj);
				});
			}
		}

		var bubble = (ProjectIdeasStats)obj.GetComponentInChildren (typeof(ProjectIdeasStats));
		bubble.projectName = title.Title;
		bubble.artDifficulty = title.RequiredSkills.ArtSkill;
		bubble.audioDifficulty = title.RequiredSkills.AudioSkill;
		bubble.codingDifficulty = title.RequiredSkills.CodingSkill;
		bubble.writingDifficulty = title.RequiredSkills.WritingSkill;
		bubble.UpdateProperties ();
	}

}
public static class RandomGenerator
{
	static int seed = 123456789;
	public static int Next()
	{
		seed = (103515245 * seed + 12345) % 65536;
		return seed;
	}
}