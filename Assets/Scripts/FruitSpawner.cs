using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs;  // Array of different fruit prefabs that will spawn
    public float spawnRate = 2f;  // Time interval between each fruit spawn

    void Start()
    {
        // Call the SpawnFruit function repeatedly, starting after 1 second, then every 'spawnRate' seconds
        InvokeRepeating("SpawnFruit", 1f, spawnRate);
    }

    void SpawnFruit()
    {
        // Pick a random fruit from the fruitPrefabs array
        int randomIndex = Random.Range(0, fruitPrefabs.Length);
        GameObject randomFruit = fruitPrefabs[randomIndex];

        // Generate a random position on the x-axis between -9 and 9, and set the spawn position slightly above the screen
        Vector2 spawnPosition = new Vector2(Random.Range(-9f, 9f), 10f);

        // Instantiate the randomly selected fruit at the spawn position with no rotation (Quaternion.identity)
        Instantiate(randomFruit, spawnPosition, Quaternion.identity);
    }
}
