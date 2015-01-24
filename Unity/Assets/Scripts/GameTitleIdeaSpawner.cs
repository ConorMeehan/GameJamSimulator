using UnityEngine;
using System.Collections;

public class GameTitleIdeaSpawner : MonoBehaviour {

	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 1f;		// The amount of time before spawning starts.
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
