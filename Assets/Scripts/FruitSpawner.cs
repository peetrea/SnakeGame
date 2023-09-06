using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject pearPrefab;
    public GameObject orangePrefab;

    public float spawnInterval = 3.0f;

    private void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            GameObject selectedFruitPrefab = GetRandomFruitPrefab();

            if (selectedFruitPrefab != null)
        {
            float randomX = Random.Range(-4f, 21f);
            float randomY = -0.5f;
            float randomZ = Random.Range(-9f, 17f);

            Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

            Instantiate(selectedFruitPrefab, transform.position + randomPosition, Quaternion.identity);
        }

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private GameObject GetRandomFruitPrefab()
    {
        GameObject[] fruitPrefabs = { applePrefab, pearPrefab, orangePrefab };

        int randomIndex = Random.Range(0, fruitPrefabs.Length);
        return fruitPrefabs[randomIndex];
    }
}
