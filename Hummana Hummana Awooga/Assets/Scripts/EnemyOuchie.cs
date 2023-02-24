using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOuchie : MonoBehaviour
{

    // preset data in case if you didn't add edata
    [SerializeField]
    private float speed = 8f;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Swarm();
    }

    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

}
