using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Prefabi viholliselle
    public GameObject enemyPrefab;

    // Alueen rajat, johon vihollinen spawnaa
    public Transform spawnAreaMin; // Vasen alakulma
    public Transform spawnAreaMax; // Oikea yläkulma

    // Aikaväli vihollisten spawnaamiselle
    public float spawnInterval = 2.0f;

    void Start()
    {
        // Aloitetaan vihollisten spawnaus määritetyllä aikavälillä
        InvokeRepeating("SpawnEnemy", 0, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Satunnaiset koordinaatit määritellyn alueen sisällä (myös Z-akseli)
        float xPos = Random.Range(spawnAreaMin.position.x, spawnAreaMax.position.x);
        float yPos = Random.Range(spawnAreaMin.position.y, spawnAreaMax.position.y);
        float zPos = Random.Range(spawnAreaMin.position.z, spawnAreaMax.position.z);

        // Spawnaa vihollinen satunnaisiin koordinaatteihin 3D-tilassa
        Vector3 spawnPosition = new Vector3(xPos, yPos, zPos);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}

