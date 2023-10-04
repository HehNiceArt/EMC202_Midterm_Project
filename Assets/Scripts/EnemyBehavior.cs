using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    private GameObject enemy;
    private float respawnTime;
    public float enemySpawnRate;
    public float timeToLive;
    private bool isSpawning = false;

    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!isSpawning)
        {
            StartCoroutine(EnemySpawning());
        }
       Destroy(enemy, timeToLive);
    }

    IEnumerator EnemySpawning()
    {
        isSpawning = true;
        EnemySpawn();
        yield return new WaitForSeconds(enemySpawnRate);
        isSpawning=false;
    }
    void EnemySpawn()
    {
        float randomXRange = Random.Range(-20, 20);
        float randomZRange = Random.Range(-20, 20);
        Vector3 randomPosition = new Vector3(randomXRange, 1, randomZRange);
        enemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}
