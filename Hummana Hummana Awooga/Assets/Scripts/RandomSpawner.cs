using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject ItemPrefab;
    public float radius = 1;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) SpawnObjectAtRandom();
    }

    void SpawnObjectAtRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * radius;

        Instantiate(ItemPrefab, randomPos, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
