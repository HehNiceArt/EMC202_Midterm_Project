using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehavior : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] enemyPositions;
    int spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    // Update is called once per frame
    IEnumerator EnemySpawn()
    {
        while(true)
        {
            var pos = enemyPositions[spawnPoint];
            Instantiate(enemy, pos.position, Quaternion.identity);
            spawnPoint = (spawnPoint + 1) % enemyPositions.Length;
            yield return new WaitForSeconds(1.5f);
        }
    }
}
