using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    // Variabile pentru prefaburile de fructe
    public GameObject applePrefab;
    public GameObject pearPrefab;
    public GameObject orangePrefab;

    // Intervalul de timp între generarea aleatoare a fructelor
    public float spawnInterval = 3.0f;

    // Raza în care fructele vor apărea aleatoriu
    public float spawnRadius = 5.0f;

    private void Start()
    {
        // Porniți o rutină pentru a genera fructe la intervale regulate
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            // Selectați aleatoriu un tip de fruct
            GameObject selectedFruitPrefab = GetRandomFruitPrefab();

            if (selectedFruitPrefab != null)
            {
                // Generați o poziție aleatoare în raza specificată
                Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
                randomPosition.y = 0; // Asigurați-vă că fructele sunt pe același plan orizontal

                // Instantiați fructul la poziția aleatoare
                Instantiate(selectedFruitPrefab, transform.position + randomPosition, Quaternion.identity);
            }

            // Așteptați pentru următoarea generare aleatoare
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private GameObject GetRandomFruitPrefab()
    {
        // Creează un tablou cu prefaburile de fructe
        GameObject[] fruitPrefabs = { applePrefab, pearPrefab, orangePrefab };

        // Selectează aleatoriu un prefab din tablou
        int randomIndex = Random.Range(0, fruitPrefabs.Length);
        return fruitPrefabs[randomIndex];
    }
}
