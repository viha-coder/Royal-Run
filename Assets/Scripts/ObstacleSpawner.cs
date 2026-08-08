using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] float obtacleSpawnTime = 1f;

    void Start()
    {
        StartCoroutine(SpawnObstacleRoutine());
    }

    IEnumerator SpawnObstacleRoutine()
    {
       while (true)
        {
            yield return new WaitForSeconds(obtacleSpawnTime);
            Instantiate(obstaclePrefab, transform.position, Random.rotation);
        }  
    }


}
