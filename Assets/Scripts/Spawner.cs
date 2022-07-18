using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("The Prefab to be spawned into the scene.")]
    public GameObject spawnPrefab = null;

    [Tooltip("The time between spawns")]
    public float spawnTime = 5.0f;

    [Tooltip("The spawn position")]
    public GameObject spawnPosition;

    // keep track of time passed for next spawn
    private float nextSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // update the time until nextSpawn
        nextSpawn += Time.deltaTime;

        // if time to spawn
        if (nextSpawn > spawnTime)
        {
            // Spawn the gameObject at the spawners current position and rotation
            GameObject projectileGameObject = Instantiate(spawnPrefab, spawnPosition.transform.position, transform.rotation, null);

            // reset the time until nextSpawn
            nextSpawn = 0f;
        }

    }
}
