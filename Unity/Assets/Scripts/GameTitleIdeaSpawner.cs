using UnityEngine;
using System.Collections;

public class GameTitleIdeaSpawner : MonoBehaviour {

	private float spawnTime = 5.0f+(RandomGenerator.Next() % 100)/40.0f;		// The amount of time between each spawn.
	private float spawnDelay = (RandomGenerator.Next() % 100)/10.0f;		// The amount of time before spawning starts.
	public GameObject prefab;		// Array of enemy prefabs.

	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	
	void Spawn ()
	{
		// Instantiate a random enemy.
		var obj = Instantiate (prefab);//, transform.position, transform.rotation);
		((GameObject)obj).transform.parent = this.gameObject.transform;
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