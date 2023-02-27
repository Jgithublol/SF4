using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject SwamerPrefab;

    [SerializeField]
    private GameObject BigSwarmerPrefab;

    [SerializeField]
    private float SwamerInterval = 3f;

    [SerializeField]
    private float BigSwarmerInterval = 4f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(SwamerInterval, SwamerPrefab));
        StartCoroutine(spawnEnemy(BigSwarmerInterval, BigSwarmerPrefab));
    }
    
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
