using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruitPrefabs;  // Array of different fruit prefabs
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("SpawnFruit", 1f, spawnRate);
    }

    void SpawnFruit()
    {
        int randomIndex = Random.Range(0, fruitPrefabs.Length);  // Pick a random fruit prefab
        GameObject randomFruit = fruitPrefabs[randomIndex];

        Vector2 spawnPosition = new Vector2(Random.Range(-9f, 9f), 10f);
        Instantiate(randomFruit, spawnPosition, Quaternion.identity);
    }
}
